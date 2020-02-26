﻿// <auto-generated />
using System;
using Cf.Libs.DataAccess.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Cf.Libs.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190919074619_db2019091901")]
    partial class db2019091901
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<DateTime>("LastPasswordChanged");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("UserProfileId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("UserProfileId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifyUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("varchar(300)");

                    b.Property<string>("UpdatedToken")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.Property<int?>("RoleId1");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.UserToken", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Common.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("District");

                    b.Property<int>("DistrictId");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifyUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Phone");

                    b.Property<string>("Province");

                    b.Property<int>("ProvinceId");

                    b.Property<string>("Street");

                    b.Property<string>("UpdatedToken")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ward");

                    b.Property<int>("WardId");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Common.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifyUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Phone");

                    b.Property<bool>("Seen");

                    b.Property<string>("UpdatedToken")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Common.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Name");

                    b.Property<string>("Prefix");

                    b.Property<int>("ProvinceId");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("District");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Common.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Name");

                    b.Property<string>("Prefix");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Common.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Common.Ward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<int>("DistrictId");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Name");

                    b.Property<string>("Prefix");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Ward");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Configuration.Setting", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreateUserId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("ModifyUserId");

                    b.Property<string>("Name");

                    b.Property<string>("Note");

                    b.Property<string>("UpdatedToken");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Items.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description");

                    b.Property<bool>("Highlight");

                    b.Property<string>("Image");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int?>("MethodId");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifyUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name");

                    b.Property<string>("Note")
                        .HasColumnType("varchar(300)");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Type");

                    b.Property<string>("UpdatedToken")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("MethodId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Items.Method", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description");

                    b.Property<bool>("EnableDiscount");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifyUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name");

                    b.Property<string>("Note")
                        .HasColumnType("varchar(300)");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Type");

                    b.Property<string>("UpdatedToken")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Method");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Items.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<DateTime>("ApplyDate")
                        .HasColumnType("timestamp");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Discount");

                    b.Property<decimal>("DiscountRate");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("timestamp");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ItemCode");

                    b.Property<int>("ItemId");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifyUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("varchar(300)");

                    b.Property<byte>("Priority");

                    b.Property<decimal>("Rate");

                    b.Property<byte>("Tax");

                    b.Property<string>("UpdatedToken")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.News.Post", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublished");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifyUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("varchar(300)");

                    b.Property<DateTime?>("PublishedDate");

                    b.Property<string>("Title");

                    b.Property<string>("UniqueUrl");

                    b.Property<string>("UpdatedToken")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Orders.Order", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("DateOfReceipt");

                    b.Property<int>("DistrictId");

                    b.Property<string>("DistrictName");

                    b.Property<string>("FullName");

                    b.Property<string>("HoursOfReceipt");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifyUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("varchar(300)");

                    b.Property<string>("OrderCode");

                    b.Property<string>("Phone");

                    b.Property<int>("ProvinceId");

                    b.Property<string>("ProvinceName");

                    b.Property<string>("Street");

                    b.Property<string>("UpdatedToken")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("WardId");

                    b.Property<string>("WardName");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Orders.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("MethodId");

                    b.Property<string>("MethodName");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifyUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("varchar(300)");

                    b.Property<string>("OrderId");

                    b.Property<string>("Type");

                    b.Property<string>("UpdatedToken")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Seo.SeoMetadata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("Name");

                    b.Property<string>("RecordId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("RecordId");

                    b.ToTable("SeoMetadata");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Seo.SeoRecord", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Keywords");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("SeoRecord");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Static.Page", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("CreateUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifyUserId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Note")
                        .HasColumnType("varchar(300)");

                    b.Property<int>("SortOrder");

                    b.Property<string>("Title");

                    b.Property<string>("UniqueUrl");

                    b.Property<string>("UpdatedToken")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Page");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.RoleClaim", b =>
                {
                    b.HasOne("Cf.Libs.DataAccess.Entities.Account.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.User", b =>
                {
                    b.HasOne("Cf.Libs.DataAccess.Entities.Account.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.UserClaim", b =>
                {
                    b.HasOne("Cf.Libs.DataAccess.Entities.Account.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.UserLogin", b =>
                {
                    b.HasOne("Cf.Libs.DataAccess.Entities.Account.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.UserRole", b =>
                {
                    b.HasOne("Cf.Libs.DataAccess.Entities.Account.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cf.Libs.DataAccess.Entities.Account.Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId1");

                    b.HasOne("Cf.Libs.DataAccess.Entities.Account.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Account.UserToken", b =>
                {
                    b.HasOne("Cf.Libs.DataAccess.Entities.Account.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Common.District", b =>
                {
                    b.HasOne("Cf.Libs.DataAccess.Entities.Common.Province", "Province")
                        .WithMany("Districts")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Common.Ward", b =>
                {
                    b.HasOne("Cf.Libs.DataAccess.Entities.Common.District", "District")
                        .WithMany("Wards")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Items.Item", b =>
                {
                    b.HasOne("Cf.Libs.DataAccess.Entities.Items.Method", "Method")
                        .WithMany("Items")
                        .HasForeignKey("MethodId");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Orders.Order", b =>
                {
                    b.HasOne("Cf.Libs.DataAccess.Entities.Common.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Orders.OrderDetail", b =>
                {
                    b.HasOne("Cf.Libs.DataAccess.Entities.Orders.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Cf.Libs.DataAccess.Entities.Seo.SeoMetadata", b =>
                {
                    b.HasOne("Cf.Libs.DataAccess.Entities.Seo.SeoRecord", "SeoRecord")
                        .WithMany("SeoMetadatas")
                        .HasForeignKey("RecordId");
                });
#pragma warning restore 612, 618
        }
    }
}
