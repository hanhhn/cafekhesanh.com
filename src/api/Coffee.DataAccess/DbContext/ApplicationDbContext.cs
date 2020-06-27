using Coffee.DataAccess.Entities;
using Coffee.DataAccess.Entities.Account;
using Coffee.DataAccess.Entities.Billing;
using Coffee.DataAccess.Entities.Common;
using Coffee.DataAccess.Entities.Configuration;
using Coffee.DataAccess.Entities.News;
using Coffee.DataAccess.Entities.Orders;
using Coffee.DataAccess.Seed;
using Coffee.Libs.DataAccess.Identity.DbContext;
using Coffee.Libs.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Coffee.DataAccess.DbContext
{
	public class ApplicationDbContext : IdentityApplicationDbContext, IDbContext
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
			SeedDefault.Seeding(builder);
		}
	}
}