﻿using Coffee.Libs.DataAccess.EntityRoot;
using Microsoft.AspNetCore.Identity;

namespace Coffee.DataAccess.Entities.Account
{
	public class UserLogin : IdentityUserLogin<string>, IEntityRoot
	{
	}
}