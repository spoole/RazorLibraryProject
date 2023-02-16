﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorLibraryProject.Data;

#nullable disable

namespace RazorLibraryProject.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230215020059_NoMoreGhosts")]
    partial class NoMoreGhosts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ed59f69e-7556-496c-9553-d5a10163a105",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a8b9523b-c154-42a8-9abe-1e6ffc000842",
                            Email = "eric.vonrueden15@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAECtHga14yo6Eax/wBnDBlY/mV9idNHv2XCgu3I97SoRlPxHj4V+D41dyHMfKTTBUyw==",
                            PhoneNumber = "1-714-971-1123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "08529e6f-003f-4c16-997d-5938b88cef06",
                            TwoFactorEnabled = false,
                            UserName = "Eric.VonRueden15"
                        },
                        new
                        {
                            Id = "14c47224-c354-4847-9c86-80aed3f33d17",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8536274b-2701-4987-9575-9b74cce28f9e",
                            Email = "drew.rau61@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEAavoyt3PAtEyRc3+W5CwcfX0geLJd5IOU6b0vDPri+Q+xWIvDLY9KDnBdVCC2ql7w==",
                            PhoneNumber = "608.288.4642",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e080d61a-2899-40f4-a0f1-022f8b310bfa",
                            TwoFactorEnabled = false,
                            UserName = "Drew.Rau61"
                        },
                        new
                        {
                            Id = "47a15d8c-ea92-4b72-8d97-26fa5dd25698",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a78191fe-b0b4-4fb2-bf13-6656c031a647",
                            Email = "ray35@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEIOPekf3gqZ6unCRBqdqqzdYdIopfIDbVPLhvnK0n93wLvlw/HjCJV8HbPvCxm4acg==",
                            PhoneNumber = "937-423-6707 x43735",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3b850a1b-789d-4311-a125-07d0ec94fd4e",
                            TwoFactorEnabled = false,
                            UserName = "Ray35"
                        },
                        new
                        {
                            Id = "964dd6d4-b1c2-473c-876c-380589dde4cb",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fc3fe877-2f14-4393-9c5b-3f23260c9a5c",
                            Email = "anna_labadie@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEPPxp/GJjUATVo9SZi5P+yeeOGcZfC/2s79o/cLAZNUroydf43l1a6ZtJYnIV1t5ng==",
                            PhoneNumber = "(362) 277-5934 x273",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c6324482-b208-404a-834e-6388b2248d53",
                            TwoFactorEnabled = false,
                            UserName = "Anna_Labadie"
                        },
                        new
                        {
                            Id = "8287c8a6-a077-4d8b-b6b8-65de31686c10",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a2d97b1e-44c9-439f-bce6-12590e177dfe",
                            Email = "doug33@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEKFvSw5miuw4Qjvb1fUemY5y0arPLmDSalezKJB8mvKZzxJ1PCeAU4Px8YyloZwpNw==",
                            PhoneNumber = "821.263.3279 x3938",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1b0de1c3-944c-4336-aefd-413b70ea67ec",
                            TwoFactorEnabled = false,
                            UserName = "Doug33"
                        },
                        new
                        {
                            Id = "01120c5d-6dc8-44f7-9150-3f30398e9591",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b55cd304-4ca1-4778-87db-93fc3bc6a21e",
                            Email = "kathy.hayes20@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEMEFlt2R9rE/LduI9LrQb16yDLjZ+/ztPYXqVyFPw/VsGWqrgumUxehiLEFQzmNpuw==",
                            PhoneNumber = "287-397-8061",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5810e9df-e77a-4956-83d4-270fbc3e673e",
                            TwoFactorEnabled = false,
                            UserName = "Kathy.Hayes20"
                        },
                        new
                        {
                            Id = "068a9fef-920e-4b3b-8038-7e1943fb8bae",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6cac40a9-1a79-4d77-8013-c1df4b3a68d3",
                            Email = "leon11@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEMElH55dqxhDgCQwQ2XdLeJu+aqZQdXOwv9iW6kekapJHsIoPedUKSHAtf3l3liamg==",
                            PhoneNumber = "1-248-765-8356",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bdaed841-f6c0-4ca6-8e06-8bc3c7478942",
                            TwoFactorEnabled = false,
                            UserName = "Leon11"
                        },
                        new
                        {
                            Id = "ccfd5ba7-48d3-4991-9c58-c5fbdfb9bf79",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e5fae074-da03-4fd9-8054-1a6d869a68e2",
                            Email = "evan_klocko38@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAELnXobWnT+gOTrjBEhbyGWPwm4Fn3xFNBGj56vktSQ6BMXV5Q3GfqbYye/d3gCatMA==",
                            PhoneNumber = "1-371-256-4490",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bc05fa62-d5e4-40b6-96ec-70b1e8b06e7e",
                            TwoFactorEnabled = false,
                            UserName = "Evan_Klocko38"
                        },
                        new
                        {
                            Id = "4a6d3ebf-17d9-463d-a4e6-17dedc32839f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7627450f-0080-4ef7-b586-f468ddfa6416",
                            Email = "gerardo.nienow72@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEHB8HA1gHdHlVhQCQ3sRUWIiwB+3X0n/i1yLDeWX4hQMraqxcq7L2EZEYaaP2Noduw==",
                            PhoneNumber = "1-965-729-6416",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f5a8a97c-c7ae-429d-8ae5-7308059c1715",
                            TwoFactorEnabled = false,
                            UserName = "Gerardo.Nienow72"
                        },
                        new
                        {
                            Id = "64f41664-a770-4e8c-be00-d7d03fae60f1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9aad4ad1-e5d6-4558-a25d-04555a8a228e",
                            Email = "marcos_ledner@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEIX4WzW34j8lixw6L5pLzD2OIVC/uDq8IvgDnq+xkmD9+POowLxOgtKkShL11tqNaA==",
                            PhoneNumber = "1-508-932-9281",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0b31db5d-a388-4feb-9fe1-e59c2006748b",
                            TwoFactorEnabled = false,
                            UserName = "Marcos_Ledner"
                        },
                        new
                        {
                            Id = "a621b254-f6d8-40d5-bfd1-64fc5533e1a0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "85e2aaef-74d1-48c1-8755-35283fbcc5e2",
                            Email = "bobby_block15@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEB8ATMp1py2n38Dht6FKMJTDbRKlxMMGEVzzv+nt07jQac70bz2R2QacF0Gm3IR2pA==",
                            PhoneNumber = "352-688-1560",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b497268b-432d-40d3-a3f5-b6654c91460b",
                            TwoFactorEnabled = false,
                            UserName = "Bobby_Block15"
                        },
                        new
                        {
                            Id = "53abb2dc-aab1-4b4b-9c76-466e3b81655e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b8084e0-088e-42fe-9a40-47dc56e3c36d",
                            Email = "gustavo_abernathy@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEJuyJhJsu8k+ttXrRBU3szvknBf7OxWHv0tmej2u3cM3yxS+GPfjd7CqFVxK9hxcJA==",
                            PhoneNumber = "234-978-0072 x24267",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "37a40676-cab5-44de-a447-a0d2ad9b5ed7",
                            TwoFactorEnabled = false,
                            UserName = "Gustavo_Abernathy"
                        },
                        new
                        {
                            Id = "cca482fc-9d3c-4c8f-9590-32b1fd118908",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d2906f4c-2d12-4168-afb8-90e2ce79c09e",
                            Email = "dianna_mohr@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEM3hTFx48cVmjj0QLXMarhADbKLo11qjTy31TFM89QLfZB1CP6jq8UmkNVoc4fZU3w==",
                            PhoneNumber = "(784) 216-3634",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d8a47083-74f0-4202-88ac-a21ae3a043f5",
                            TwoFactorEnabled = false,
                            UserName = "Dianna_Mohr"
                        },
                        new
                        {
                            Id = "78703e8e-5784-4915-a6a8-8526834695c3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e2622888-ba19-4bbd-a44f-d830c90b749a",
                            Email = "abraham81@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEHs7h4rmFZEuMsegP6/W1tB+g0mZAHJXkvLuGMClyPioC5/gaVpGJGi+Gl1WwiAGkw==",
                            PhoneNumber = "1-542-987-0359",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fd41a3ed-8cb0-42d2-aae6-fef10fcefd4e",
                            TwoFactorEnabled = false,
                            UserName = "Abraham81"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RazorLibraryProject.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorFirst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorLast")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAvailable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Book");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}