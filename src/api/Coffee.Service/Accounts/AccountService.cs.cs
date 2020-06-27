using AutoMapper;
using Coffee.Core.Infrastructure.Service;
using Coffee.Core.Infrastructure.UnitOfWork;
using Coffee.Service.Dtos.Account;
using Coffee.Service.Entities.Account;
using Coffee.Service.Repository.UserProfiles;
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

namespace Coffee.Application.Accounts
{
	public class AccountService : BaseService, IAccountService
	{

	}
}