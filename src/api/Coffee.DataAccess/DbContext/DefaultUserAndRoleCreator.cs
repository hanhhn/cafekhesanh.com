using Coffee.Libs.DataAccess.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee.DataAccess.DbContext
{
	public class DefaultUserAndRoleCreator
	{
		private readonly RoleManager<AppRole> _roleManager;
		private readonly UserManager<AppUser> _userManager;

		public DefaultUserAndRoleCreator(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
		{
			_roleManager = roleManager;
			_userManager = userManager;
		}

		public void Create()
		{
			CreateDefaultRole();
			CreateDefaultUser().Wait();
		}

		/// <summary>
		/// Create default users
		/// Admin user: user name from config
		/// Password default: 123qwe@ASD
		/// </summary>
		private async Task CreateDefaultUser()
		{
			if (_userManager.Users.Any())
				return;

			var adminUser = new AppUser
			{
				Email = "admin@cafekhesanh.com",
				UserName = "admin@cafekhesanh.com",
				NormalizedUserName = "admin@cafekhesanh.com".ToUpper(),
				EmailConfirmed = true,
				LockoutEnabled = false
			};

			await _userManager.CreateAsync(adminUser, "admin@123a");
			await _userManager.AddToRoleAsync(adminUser, "admin");
			await _userManager.AddToRoleAsync(adminUser, "customer");
			await _userManager.AddToRoleAsync(adminUser, "editor");
		}

		/// <summary>
		/// Create default host roles:
		/// Admin role: management permissions
		/// Candidate role: candidate permissions
		/// Business role: company permissions
		/// </summary>
		private void CreateDefaultRole()
		{
			if (_roleManager.Roles.Any())
				return;

			_roleManager.CreateAsync(new AppRole
			{
				Name = "admin",
				NormalizedName = "admin"
			}).Wait();

			_roleManager.CreateAsync(new AppRole
			{
				Name = "customer",
				NormalizedName = "customer"
			}).Wait();

			_roleManager.CreateAsync(new AppRole
			{
				Name = "editor",
				NormalizedName = "editor"
			}).Wait();
		}
	}
}
