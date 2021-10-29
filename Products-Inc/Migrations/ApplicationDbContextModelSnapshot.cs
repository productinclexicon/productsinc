﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Products_Inc.Data;

namespace Products_Inc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "c047ce55-a2c0-4611-9708-adbce3086535",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "0948bea6-fb82-49c9-8cd8-fec213fe8e8a",
                            ConcurrencyStamp = "b8543155-3520-475b-b5ff-b96bffe5bbb8",
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
                            UserId = "0001",
                            RoleId = "438db5c8-0513-43a0-a84c-cd416c4e3a54"
                        },
                        new
                        {
                            UserId = "0001",
                            RoleId = "0948bea6-fb82-49c9-8cd8-fec213fe8e8a"
                        },
                        new
                        {
                            UserId = "0010",
                            RoleId = "0948bea6-fb82-49c9-8cd8-fec213fe8e8a"
                        },
                        new
                        {
                            UserId = "0020",
                            RoleId = "0948bea6-fb82-49c9-8cd8-fec213fe8e8a"
                        },
                        new
                        {
                            UserId = "0030",
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

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            UserId = "0030"
                        },
                        new
                        {
                            OrderId = 2,
                            UserId = "0010"
                        },
                        new
                        {
                            OrderId = 3,
                            UserId = "0020"
                        },
                        new
                        {
                            OrderId = 4,
                            UserId = "0020"
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
                            Amount = 0,
                            OrderId = 1,
                            ProductId = 10
                        },
                        new
                        {
                            OrderProductId = 2,
                            Amount = 0,
                            OrderId = 1,
                            ProductId = 10
                        },
                        new
                        {
                            OrderProductId = 3,
                            Amount = 0,
                            OrderId = 1,
                            ProductId = 30
                        },
                        new
                        {
                            OrderProductId = 4,
                            Amount = 0,
                            OrderId = 1,
                            ProductId = 40
                        },
                        new
                        {
                            OrderProductId = 5,
                            Amount = 0,
                            OrderId = 1,
                            ProductId = 30
                        },
                        new
                        {
                            OrderProductId = 6,
                            Amount = 0,
                            OrderId = 1,
                            ProductId = 20
                        },
                        new
                        {
                            OrderProductId = 7,
                            Amount = 0,
                            OrderId = 3,
                            ProductId = 20
                        },
                        new
                        {
                            OrderProductId = 8,
                            Amount = 0,
                            OrderId = 3,
                            ProductId = 30
                        },
                        new
                        {
                            OrderProductId = 9,
                            Amount = 0,
                            OrderId = 3,
                            ProductId = 10
                        },
                        new
                        {
                            OrderProductId = 10,
                            Amount = 0,
                            OrderId = 3,
                            ProductId = 10
                        },
                        new
                        {
                            OrderProductId = 11,
                            Amount = 0,
                            OrderId = 3,
                            ProductId = 20
                        },
                        new
                        {
                            OrderProductId = 12,
                            Amount = 0,
                            OrderId = 3,
                            ProductId = 30
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
                            Id = "0001",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cecb1189-198d-410e-b2d0-a04abcb5d503",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAENCGS5wMtAsiBD+8gkMARe0skD2Z0xPOw5HL+miMBcMOGiuO+HYYhih7tlGAWqtSbg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6e991e82-6ffb-4e7a-b318-9cc757b2a8f6",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "0010",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3344c1d2-94ee-4556-bcc8-d2e1dc331803",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "CUSTOMER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEH2TP46w3R5hpog2DyiKWR1QhwqH6ZUJFSupG0tFtmApyYvZILBsJmbh6OB6Gfe2Ug==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2cffcb50-6b63-4ce4-8211-ca2406f1c9a0",
                            TwoFactorEnabled = false,
                            UserName = "customer1"
                        },
                        new
                        {
                            Id = "0020",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4e731ee0-065f-4de7-be78-e7ead2a3a336",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "CUSTOMER2",
                            PasswordHash = "AQAAAAEAACcQAAAAEBzJBK+kESvwU/sbiUHs8hviqTHfk31ayYr8fkpUhSVub2+erMlqmlOIoEmFXK4XfA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4c62bd3c-084e-4734-bba4-1e9488fb4901",
                            TwoFactorEnabled = false,
                            UserName = "customer2"
                        },
                        new
                        {
                            Id = "0030",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e0758bba-a0de-46bf-90ea-d4405c3796b2",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "CUSTOMER3",
                            PasswordHash = "AQAAAAEAACcQAAAAEPV0YjHz6DMaDkTPxPfwKkEdV87QFAxXrQwOrtDroSI3Z4iN2ZKBOvAo59PFxoBq3g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ed6555a8-90f9-42c2-a3cf-3ebc98032fec",
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
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("Products_Inc.Models.User", null)
                        .WithMany("Orders")
                        .HasForeignKey("UserId1");
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
