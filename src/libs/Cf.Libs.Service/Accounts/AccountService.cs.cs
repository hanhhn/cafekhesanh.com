using AutoMapper;
using Cf.Libs.Core.Infrastructure.Service;
using Cf.Libs.Core.Infrastructure.UnitOfWork;
using Cf.Libs.DataAccess.Entities.Account;
using Cf.Libs.DataAccess.Repository.UserProfiles;
using Cf.Libs.DataAccess.Dtos.Account;
using Cf.Libs.Service.Emails;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Cf.Libs.Service.Accounts
{
	public class AccountService : BaseService, IAccountService
	{
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;
		private readonly RoleManager<Role> _roleManager;
		private readonly IEmailSenderService _emailSender;
		private readonly IUserProfileRepository _userProfileRepository;
		private readonly IConfiguration _configuration;

		public AccountService(
			IUnitOfWork unitOfWork,
			IMapper mapper,
			UserManager<User> userManager,
			SignInManager<User> signInManager,
			EmailSenderService emailSender,
			IConfiguration configuration,
			IUserProfileRepository userProfileRepository) : base(unitOfWork, mapper)
		{
			_configuration = configuration;
			_userManager = userManager;
			_signInManager = signInManager;
			_emailSender = emailSender;
			_userProfileRepository = userProfileRepository;
		}

		public async Task<LoginResponse> SigninAsyn(SigninDto model)
		{

			try
			{
				LoginResponse loginInfo = new LoginResponse();

				var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

				if (result.Succeeded)
				{
					var user = await _userManager.FindByEmailAsync(model.Email);
					if (!user.EmailConfirmed)
					{
						throw new Exception("Must be confirmed email before login.");
					}

					var token = await GenerateJwtToken(model.Email, user);
					loginInfo.Token = token.ToString();

					var roles = await _userManager.GetRolesAsync(user);
					loginInfo.Role = roles.ToList();

					var profile = _userProfileRepository.FindBy(x => x.UserId == user.Id).SingleOrDefault();
					if (profile != null)
					{
						loginInfo.Image = profile.ProfileImage;
						loginInfo.FullName = profile.FullName;
					}

					return loginInfo;
				}

				throw new ApplicationException("Login failed.");
			}
			catch
			{
				await _signInManager.SignOutAsync();
				throw new ApplicationException("Login failed.");
			}
		}

		public async Task<bool> SignupAsyn(SignupDto model)
		{
			// create user account
			var user = new User
			{
				UserName = model.Email,
				NormalizedUserName = model.Email.ToUpper(),
				Email = model.Email,
				EmailConfirmed = false,
				PhoneNumber = model.Phone,
				PhoneNumberConfirmed = false,
			};

			IdentityResult result = await _userManager.CreateAsync(user, model.Password);
			var insertedUser = await _userManager.FindByNameAsync(model.Email);

			if (result.Succeeded && insertedUser != null)
			{
				var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
				string callbackUrl = string.Format("{0}/{1}", "https://localhost", token);
				string content = $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.";
				await _emailSender.SendEmailAsync(user.Email, "Confirm your email", content);

				// create employee
				var profile = new UserProfile
				{
					FirstName = model.FirstName,
					LastName = model.LastName,
					Phone = model.Phone,
					Email = model.Email
				};

				_userProfileRepository.Add(profile);
				_unitOfWork.SaveChanges();

				return true;
			}

			return false;
		}

		public async Task SignoutAsyn()
		{
			await _signInManager.SignOutAsync();
		}

		public async Task<bool> ForgetPassowordAsyn(string email)
		{
			var user = await _userManager.FindByNameAsync(email);
			if(user == null)
			{
				var token = await _userManager.GeneratePasswordResetTokenAsync(user);
				string callbackUrl = string.Format("{0}/{1}", "https://localhost/", token);
				string content = $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.";
				await _emailSender.SendEmailAsync(user.Email, "Reset password", content);
				return true;
			}
			return false;
		}

		public async Task<bool> ChangePassowordAsyn(ChangePasswordRequest model)
		{
			var user = await _userManager.FindByIdAsync(model.UserId);
			if (user == null)
			{
				throw new ApplicationException("User don't exists.");
			}

			var changed = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

			user.LastPasswordChanged = DateTime.Now;
			await _userManager.UpdateAsync(user);

			return changed.Succeeded;
		}

		public async Task<bool> ResetPassowordAsyn(ResetPasswordRequest model)
		{
			var user = await _userManager.FindByIdAsync(model.UserId);
			if (user == null)
			{
				throw new ApplicationException("User don't exists.");
			}

			var token = await _userManager.GeneratePasswordResetTokenAsync(user);
			var changed = await _userManager.ChangePasswordAsync(user, token, model.Password);

			return changed.Succeeded;
		}

		public async Task<bool> ConfirmPassowordAsyn(string email, string token, string password)
		{
			var user = await _userManager.FindByIdAsync(email);
			if (user == null)
			{
				throw new ApplicationException("User don't exists.");
			}

			var changed = await _userManager.ChangePasswordAsync(user, token, password);

			return changed.Succeeded;
		}

		public async Task<bool> ConfirmEmailAsyn(string email, string token)
		{
			var user = await _userManager.FindByIdAsync(email);
			if (user == null)
			{
				throw new ApplicationException("User don't exists.");
			}

			var changed = await _userManager.ConfirmEmailAsync(user, token);

			return changed.Succeeded;
		}

		public async Task<bool> ApplyRoles(ApplyRoleRequest request)
		{
			if (request == null)
				throw new Exception("Param invalid.");

			var user = await _userManager.FindByIdAsync(request.UserId);
			if (user == null)
				throw new Exception("User don't exists.");

			try
			{
				if (request.Roles.Any())
				{
					var curRoles = await _userManager.GetRolesAsync(user);

					// remove all user role			
					foreach (var r in curRoles)
					{
						await _userManager.RemoveFromRoleAsync(user, r);
					}

					// add user role
					foreach (var role in request.Roles)
					{
						await _userManager.AddToRoleAsync(user, role);
					}

					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}

			return false;
		}

		private async Task<object> GenerateJwtToken(string email, User user)
		{
			var claims = new List<Claim>
			{
				new Claim(JwtRegisteredClaimNames.Sub, email),
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
				new Claim(ClaimTypes.NameIdentifier, user.Id)
			};

			var roles = await _userManager.GetRolesAsync(user);
			AddRolesToClaims(claims, roles);

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
			var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JwtExpireDays"]));

			var token = new JwtSecurityToken(
				_configuration["JwtIssuer"],
				_configuration["JwtIssuer"],
				claims,
				expires: expires,
				signingCredentials: creds
			);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}

		private void AddRolesToClaims(List<Claim> claims, IEnumerable<string> roles)
		{
			foreach (var role in roles)
			{
				var roleClaim = new Claim(ClaimTypes.Role, role);
				claims.Add(roleClaim);
			}
		}
	}
}