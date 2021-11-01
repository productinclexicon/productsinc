﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Products_Inc.Data;

namespace Products_Inc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211031205339_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "438db5c8-0513-43a0-a84c-cd416c4e3a54",
                            ConcurrencyStamp = "0353c52c-ab17-4290-9804-c4caf68814b3",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "0948bea6-fb82-49c9-8cd8-fec213fe8e8a",
                            ConcurrencyStamp = "7f37172f-b7bf-41d1-9c13-6f3c2f3fa022",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "e14c9eb3-5d96-45d2-94a8-f1b0d05a0546",
                            RoleId = "438db5c8-0513-43a0-a84c-cd416c4e3a54"
                        },
                        new
                        {
                            UserId = "e14c9eb3-5d96-45d2-94a8-f1b0d05a0546",
                            RoleId = "0948bea6-fb82-49c9-8cd8-fec213fe8e8a"
                        },
                        new
                        {
                            UserId = "e6ba6a39-4850-4583-ad13-3ea6736926b8",
                            RoleId = "0948bea6-fb82-49c9-8cd8-fec213fe8e8a"
                        },
                        new
                        {
                            UserId = "e7bec757-030e-416a-b1f6-87841484775e",
                            RoleId = "0948bea6-fb82-49c9-8cd8-fec213fe8e8a"
                        },
                        new
                        {
                            UserId = "8a888b5a-3009-437e-b834-42b42b28909a",
                            RoleId = "0948bea6-fb82-49c9-8cd8-fec213fe8e8a"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Products_Inc.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            UserId = "8a888b5a-3009-437e-b834-42b42b28909a"
                        },
                        new
                        {
                            OrderId = 2,
                            UserId = "e6ba6a39-4850-4583-ad13-3ea6736926b8"
                        },
                        new
                        {
                            OrderId = 3,
                            UserId = "e7bec757-030e-416a-b1f6-87841484775e"
                        },
                        new
                        {
                            OrderId = 4,
                            UserId = "e7bec757-030e-416a-b1f6-87841484775e"
                        });
                });

            modelBuilder.Entity("Products_Inc.Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId1")
                        .HasColumnType("int");

                    b.HasKey("OrderProductId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductId1");

                    b.ToTable("OrderProducts");

                    b.HasData(
                        new
                        {
                            OrderProductId = 1,
                            Amount = 4,
                            OrderId = 1,
                            ProductId = 50
                        },
                        new
                        {
                            OrderProductId = 2,
                            Amount = 2,
                            OrderId = 1,
                            ProductId = 52
                        },
                        new
                        {
                            OrderProductId = 3,
                            Amount = 1,
                            OrderId = 1,
                            ProductId = 57
                        },
                        new
                        {
                            OrderProductId = 4,
                            Amount = 6,
                            OrderId = 2,
                            ProductId = 52
                        },
                        new
                        {
                            OrderProductId = 5,
                            Amount = 1,
                            OrderId = 2,
                            ProductId = 54
                        },
                        new
                        {
                            OrderProductId = 6,
                            Amount = 2,
                            OrderId = 2,
                            ProductId = 56
                        },
                        new
                        {
                            OrderProductId = 7,
                            Amount = 9,
                            OrderId = 3,
                            ProductId = 55
                        },
                        new
                        {
                            OrderProductId = 8,
                            Amount = 1,
                            OrderId = 3,
                            ProductId = 57
                        },
                        new
                        {
                            OrderProductId = 9,
                            Amount = 3,
                            OrderId = 3,
                            ProductId = 51
                        },
                        new
                        {
                            OrderProductId = 10,
                            Amount = 5,
                            OrderId = 4,
                            ProductId = 52
                        },
                        new
                        {
                            OrderProductId = 11,
                            Amount = 3,
                            OrderId = 4,
                            ProductId = 53
                        },
                        new
                        {
                            OrderProductId = 12,
                            Amount = 1,
                            OrderId = 4,
                            ProductId = 55
                        });
                });

            modelBuilder.Entity("Products_Inc.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 10,
                            ProductDescription = "A nice eko quality bananas from peru.",
                            ProductName = "Pack of bananas",
                            ProductPrice = 34
                        },
                        new
                        {
                            ProductId = 20,
                            ProductDescription = "Clementine fruit.",
                            ProductName = "Satsumas",
                            ProductPrice = 6
                        },
                        new
                        {
                            ProductId = 30,
                            ProductDescription = "Sweet tomatos.",
                            ProductName = "Tomatos A-Class",
                            ProductPrice = 3
                        },
                        new
                        {
                            ProductId = 40,
                            ProductDescription = "Butter made of sunflower seeds.",
                            ProductName = "Sunflower Butter",
                            ProductPrice = 54
                        },
                        new
                        {
                            ProductId = 50,
                            ImgPath = "./img/img4.jpg",
                            ProductDescription = "Nice for your health",
                            ProductName = "Orange",
                            ProductPrice = 30
                        },
                        new
                        {
                            ProductId = 51,
                            ImgPath = "./img/img6.jpg",
                            ProductDescription = "Good to drink",
                            ProductName = "Coca Cola",
                            ProductPrice = 16
                        },
                        new
                        {
                            ProductId = 52,
                            ImgPath = "./img/img7.jpg",
                            ProductDescription = "Good for health",
                            ProductName = "Oreo",
                            ProductPrice = 10
                        },
                        new
                        {
                            ProductId = 53,
                            ImgPath = "./img/img8.jpg",
                            ProductDescription = "Healthy breakfast",
                            ProductName = "Corn Flakes",
                            ProductPrice = 25
                        },
                        new
                        {
                            ProductId = 54,
                            ImgPath = "./img/img9.jpg",
                            ProductDescription = "Nice to make food",
                            ProductName = "Salt",
                            ProductPrice = 9
                        },
                        new
                        {
                            ProductId = 55,
                            ImgPath = "./img/img12.jpg",
                            ProductDescription = "Good for health",
                            ProductName = "Avocado",
                            ProductPrice = 18
                        },
                        new
                        {
                            ProductId = 56,
                            ImgPath = "./img/img14.jpg",
                            ProductDescription = "Nice to eat",
                            ProductName = "Eggo",
                            ProductPrice = 30
                        },
                        new
                        {
                            ProductId = 57,
                            ImgPath = "./img/img16.jpg",
                            ProductDescription = "Creamy sun butter",
                            ProductName = "SunButter",
                            ProductPrice = 35
                        });
                });

            modelBuilder.Entity("Products_Inc.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("TransactionComplete")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ShoppingCartId");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Products_Inc.Models.ShoppingCartProduct", b =>
                {
                    b.Property<int>("ShoppingCartProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartProductId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ShoppingCartProducts");
                });

            modelBuilder.Entity("Products_Inc.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "e14c9eb3-5d96-45d2-94a8-f1b0d05a0546",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a9c33c0d-79f9-41ea-832d-7866ab1e3bfe",
                            Email = "customer1@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER1@EMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEBWJea8iEYxd7fbwggAHupSJ/12EbPXIT2x+8EB9vrEEHmBrU9uvMgJqgVc12kPpiQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "64651485-2c15-4c47-8271-d6528ca616ca",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "e6ba6a39-4850-4583-ad13-3ea6736926b8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4922c356-22a1-4c5d-8cab-f0fd62964435",
                            Email = "customer1@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER1@EMAIL.COM",
                            NormalizedUserName = "CUSTOMER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEGFLtNvu0CspwEEmpmc9vjUzs2n15OqUeVMeTBtHhMoy0Nrxaq+O9OFha8vKHX0H+A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5c8733b4-d502-44d9-a8d6-262f2f6be8da",
                            TwoFactorEnabled = false,
                            UserName = "customer1"
                        },
                        new
                        {
                            Id = "e7bec757-030e-416a-b1f6-87841484775e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "49f57a75-9ca4-4e59-8bff-a23dc9e4594f",
                            Email = "customer2@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER2@EMAIL.COM",
                            NormalizedUserName = "CUSTOMER2",
                            PasswordHash = "AQAAAAEAACcQAAAAEFQtTPA9HsxkhmeqJUKG0XvnyPkFpy2UtQ5uQOnIEDXT+t8on8UDUvhxwtKN6reuDQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "901de48a-0a09-42e8-84c9-01efc7c8eccc",
                            TwoFactorEnabled = false,
                            UserName = "customer2"
                        },
                        new
                        {
                            Id = "8a888b5a-3009-437e-b834-42b42b28909a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "110d819d-b9f4-4e3f-aeb5-a130482f209a",
                            Email = "customer3@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER3@EMAIL.COM",
                            NormalizedUserName = "CUSTOMER3",
                            PasswordHash = "AQAAAAEAACcQAAAAEDCDLSBDRjRLT4G//q/mM5Sr2UI890LzkQmFLnPHD62ptJP80EIAHZFWUs0od0ljnw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "544c8703-8fda-4f8a-8e54-84f3853b7b2f",
                            TwoFactorEnabled = false,
                            UserName = "customer3"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Products_Inc.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Products_Inc.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Products_Inc.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Products_Inc.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Products_Inc.Models.Order", b =>
                {
                    b.HasOne("Products_Inc.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Products_Inc.Models.OrderProduct", b =>
                {
                    b.HasOne("Products_Inc.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Products_Inc.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Products_Inc.Models.Product", null)
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId1");
                });

            modelBuilder.Entity("Products_Inc.Models.ShoppingCart", b =>
                {
                    b.HasOne("Products_Inc.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Products_Inc.Models.ShoppingCartProduct", b =>
                {
                    b.HasOne("Products_Inc.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Products_Inc.Models.ShoppingCart", "ShoppingCart")
                        .WithMany("Products")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}