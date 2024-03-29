﻿using Cf.Libs.Core.Infrastructure.Context;
using Cf.Libs.DataAccess.Entities;
using Cf.Libs.DataAccess.Entities.Account;
using Cf.Libs.DataAccess.Entities.Billing;
using Cf.Libs.DataAccess.Entities.Common;
using Cf.Libs.DataAccess.Entities.Configuration;
using Cf.Libs.DataAccess.Entities.News;
using Cf.Libs.DataAccess.Entities.Orders;
using Cf.Libs.DataAccess.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cf.Libs.DataAccess.DbContext
{
	public class ApplicationDbContext : IdentityDbContext<User, Role, string, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>, IDbContext
    {
        private const string SchemaDefault = "cf";

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Contact> Conacts { get; set; }
        public DbSet<Tracking> Trackings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.HasDefaultSchema(SchemaDefault);

            base.OnModelCreating(builder);
            TablesBuilder.Build(builder);
            CfSeedDefault.Seeding(builder);
        }
    }
}