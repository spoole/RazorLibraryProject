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
    [Migration("20230214212820_AddedBooksAndRoleChecks2")]
    partial class AddedBooksAndRoleChecks2
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
                            Id = "0d03ed3e-8290-44f9-b622-f9188c2bc0e8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2fe47e8d-c5c6-40b9-971d-0b56452021ac",
                            Email = "borrower@library.net",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "borrower@library.net",
                            NormalizedUserName = "borrower@library.net",
                            PasswordHash = "AQAAAAIAAYagAAAAEPf4ppGF2/N/7HrPe5kLdYK7Ndf5RxZnHbr1pMtawHifGDkF39Fm/W/iDXeBiqTlLQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bedcab12-c338-48a3-9fe4-fc5248a22f63",
                            TwoFactorEnabled = false,
                            UserName = "borrower@library.net"
                        },
                        new
                        {
                            Id = "0f219d7e-d201-481c-a504-bf95b02f1082",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fb5a1f1c-0e93-4405-85d0-ebfe8c314e93",
                            Email = "librarian@library.net",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "librarian@library.net",
                            NormalizedUserName = "librarian@library.net",
                            PasswordHash = "AQAAAAIAAYagAAAAEGumgrKXROxmZvKA8kohgyue2igz+FRZr7v0ZAATyFc/UWFxwgA7oHqm4bITiZKEmw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c4af566d-17fb-4031-9dab-513f13b5aef5",
                            TwoFactorEnabled = false,
                            UserName = "librarian@library.net"
                        },
                        new
                        {
                            Id = "37fe4428-c64b-434f-8ab9-e1fd4d1df1fd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "04b0775a-d6b5-4463-ae6f-d21bdb9f4580",
                            Email = "marilyn.prosacco@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEGdVkg+lHg2SUjD1/8anHQImKuSTlyigJvDChw3XyReOo0ghXMRfSnxKblqMyhd/+w==",
                            PhoneNumber = "749-965-5619 x34458",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5329f6f0-f7a8-4d57-ada5-0a9b590c9c4d",
                            TwoFactorEnabled = false,
                            UserName = "Marilyn.Prosacco"
                        },
                        new
                        {
                            Id = "d9c2664a-8885-400b-8437-095c6d9662bd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d53f8435-6213-401f-a3a3-a4923115593f",
                            Email = "susan.homenick50@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEK4VzOrtX8PbKOB+TjHuykHN7W0jcVCxr24q5N6kG67/OnkEQfRhsbc2/ggkkc2Znw==",
                            PhoneNumber = "968.323.1256 x5228",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "59dae62e-a569-4612-9129-61d506ec3e9e",
                            TwoFactorEnabled = false,
                            UserName = "Susan.Homenick50"
                        },
                        new
                        {
                            Id = "2d6b4aa5-9d5f-4ba1-90f4-087dcf63b44c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "76394bb4-6cf5-4922-8b50-d69f792d9cfc",
                            Email = "pearl.glover22@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEMbwP8wxcDmrSt13ai8pcOWa3b+X5JQx2Gq070bnGJ/iYnu5TQq9X09ia7bOyB2UKg==",
                            PhoneNumber = "289.642.4229 x970",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "63cc5ef3-3b65-4b57-84b7-e8ff2bb7116e",
                            TwoFactorEnabled = false,
                            UserName = "Pearl.Glover22"
                        },
                        new
                        {
                            Id = "f0c3e46b-141b-4353-96c7-e9e35d185044",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9d5d288d-da9a-46c0-92ab-f60869c5af8b",
                            Email = "eileen.rice81@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAECc+kMp+pKUyIy+u4OR0v0HPhublLzrf1luZIMFG9eqnNOmYpVgevJruz9jugLqhXg==",
                            PhoneNumber = "992.221.8568 x8600",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "12629ca7-e131-41eb-95a4-6a6919044d66",
                            TwoFactorEnabled = false,
                            UserName = "Eileen.Rice81"
                        },
                        new
                        {
                            Id = "11549e1e-4de4-48bb-8258-e332b3694b31",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "492dbfa6-2849-4fac-b395-ba85653c57c0",
                            Email = "courtney.renner92@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEOaEjXhL/KnbWhc7ckKwvca+9M5FKjZn8R8Ya3W+ukRwxg2tzyMTRzOjVHlWjpVzXg==",
                            PhoneNumber = "1-795-248-8802 x224",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "85346bad-5317-4b69-86cb-860acafb98d5",
                            TwoFactorEnabled = false,
                            UserName = "Courtney.Renner92"
                        },
                        new
                        {
                            Id = "46444bff-c29d-4e74-8a10-cb17c60aba08",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fe07945f-015e-4132-8438-3513c64959b8",
                            Email = "antonio43@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEGHM+KhnoM7GeXkuwB7ENhb8ftvdDKW6rOa/lzOm2F83AQqe+7Jh4z1j5zoYFC8JOA==",
                            PhoneNumber = "1-849-305-3101",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "93bb0aeb-49ad-4fb7-9b94-70e47995c424",
                            TwoFactorEnabled = false,
                            UserName = "Antonio43"
                        },
                        new
                        {
                            Id = "bf896219-1f27-4d58-84f0-ab459aa0d5f6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "44f15a82-b3c1-4693-9700-f2467580618c",
                            Email = "camille_lehner@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEMifHweSQ0tgEKte/YpDg3LQb+OxFtT3XB55rOEy8m6fUlvQb7FPnv+bETfFpbYy6A==",
                            PhoneNumber = "627-240-1093",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0e54a26d-96a6-424a-81a9-44b190ac155b",
                            TwoFactorEnabled = false,
                            UserName = "Camille_Lehner"
                        },
                        new
                        {
                            Id = "3cce72d0-12d6-459c-98d2-8464534ebfe1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7ca2a7e4-7232-47ff-87d1-380bc9014c6c",
                            Email = "garry17@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEHamyt0i/id9PcWC7dZ7UvP1THDQ98iUVtBnbHCuaZtuZwFliwlJYVY+cEqrBXOYXg==",
                            PhoneNumber = "(930) 996-9389 x60898",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cb6a4102-1dd3-44c9-9d16-28e966eac208",
                            TwoFactorEnabled = false,
                            UserName = "Garry17"
                        },
                        new
                        {
                            Id = "1f985bbb-f0f4-4261-bd61-4db9d43a5790",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "111b00cc-545d-4498-ae29-08789a5892a8",
                            Email = "ada4@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEJinRzDPoMs4LwgmnzpIcCKG3Zs+BJWP/wpsbw2Zf0Lqf1k1zzwNjGuMNbuX/rLyHQ==",
                            PhoneNumber = "(256) 680-5178",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1b382177-26ce-4ed0-a440-a0f96cc3f3c6",
                            TwoFactorEnabled = false,
                            UserName = "Ada4"
                        },
                        new
                        {
                            Id = "87017339-1666-4581-af15-49a3557063c3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d290ab75-5456-4770-a62a-86a3ab318d1d",
                            Email = "katherine.herman@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEP9iQV28F2OvIJQlDl/cw/43yVUkRjU4+ZLLafw9URuj4o0WgCiMeDwvg+lZvOUiNQ==",
                            PhoneNumber = "892.907.3049",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1acc5472-8ad9-40da-9bd3-b4c3cb08f1b5",
                            TwoFactorEnabled = false,
                            UserName = "Katherine.Herman"
                        },
                        new
                        {
                            Id = "5e06b5ef-dc60-429d-ac24-3ea25eeb7722",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8e7845e4-54ec-4b8b-9987-6910f33795d5",
                            Email = "tyrone_oreilly72@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEPM1mnclAN/a/QE5t30blnoOYjiiz+cco25PuVpgs5h4DndR1Xe0hAgdpMYdqcIzgg==",
                            PhoneNumber = "737-527-7995 x1618",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2244c754-973c-494b-9c9b-9fbec3af7513",
                            TwoFactorEnabled = false,
                            UserName = "Tyrone_OReilly72"
                        },
                        new
                        {
                            Id = "e7fde6c2-a1cd-46a1-90a1-456bdc6e1886",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "498266aa-cbf5-4518-827a-6aff756192bc",
                            Email = "lamar.wisozk@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAENo/zdaWdx+0WexxzIPQj6U4HUpb+VJsifCnpRywUU2B4D9arHdBBxlNKoFTFbbA7A==",
                            PhoneNumber = "967-967-6373 x25565",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "807f8c99-d9f9-45e6-bca5-14d9f5c3c71a",
                            TwoFactorEnabled = false,
                            UserName = "Lamar.Wisozk"
                        },
                        new
                        {
                            Id = "e0afed5b-2829-4e7f-833f-818281ff3dd0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2383887d-7d90-4c65-baa3-08f3ed208a32",
                            Email = "micheal_kassulke18@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAENtuROQ9RJpHT4AjLa3q6y0dfCnH2S/HnWRukQMqTw4j+/KwPUiYPJNraHmz7juQyQ==",
                            PhoneNumber = "483-368-9618 x366",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6dbcf47a-40c8-4d87-a60f-8805baa8498f",
                            TwoFactorEnabled = false,
                            UserName = "Micheal_Kassulke18"
                        },
                        new
                        {
                            Id = "87943e6c-60e9-4940-aeb6-7ebee74c20c2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c5101aeb-8215-46ab-9609-91050eda7f9e",
                            Email = "kathleen.morar@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEM8DuusJcfAtrKWt3AySIMJUfJf6KDGXGmSxhEr2rdANdJnUNmbVeEf19L0U+AtPBw==",
                            PhoneNumber = "(572) 786-7488 x0789",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d690f51d-77ff-4569-a485-728b041490e6",
                            TwoFactorEnabled = false,
                            UserName = "Kathleen.Morar"
                        },
                        new
                        {
                            Id = "b6f9580f-c5fc-4154-927b-26c342d26c70",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "68062f91-5bb6-477a-b9fc-80811240b09e",
                            Email = "corey.ebert26@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEJjkTEEAjEJnVnFBeTx8qi+jc+7iKln3Lpt338eavkuSF38rZ5eLRk+ZASwF7IBVVA==",
                            PhoneNumber = "529-410-6571 x5059",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9fcc5743-1c4e-4903-9357-ac6c9cf88d7b",
                            TwoFactorEnabled = false,
                            UserName = "Corey.Ebert26"
                        },
                        new
                        {
                            Id = "7ffe40bf-593c-4c87-864f-ffd6d2f4f5ef",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "99974948-c1cd-4ee8-8a0a-c69010e0010c",
                            Email = "wilfred_zemlak98@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEKzDUYsVbleh2YqOiXPnZseul/mHxqCROv9gJqSPQ8dPD1wMZrZm8RH3lAg0/7kCEA==",
                            PhoneNumber = "869-615-9085",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cdc40774-af4d-44d4-ad1b-ad8dc58a640d",
                            TwoFactorEnabled = false,
                            UserName = "Wilfred_Zemlak98"
                        },
                        new
                        {
                            Id = "a3436cb7-16ec-42d0-81e0-89c58a98d3ad",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4849e9b2-07cb-4e3c-843b-4e0be75d5a56",
                            Email = "jackie_langworth12@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEEDKue9CxFfVGDZXEqRSAHmkuqBGMjHZa5LVKEp0Uqn8mHnyicHTZ7rRNUW1HeRFNQ==",
                            PhoneNumber = "1-553-249-0524",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ee2dd0fd-808e-43d0-a918-68e34cbec8d0",
                            TwoFactorEnabled = false,
                            UserName = "Jackie_Langworth12"
                        },
                        new
                        {
                            Id = "d593ca41-b0fd-4600-b141-f8b39b8a867a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ad00f397-b680-438d-ad18-508d091a6fdb",
                            Email = "guadalupe_jerde@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEEuuXBDRcYisolJsJWbZVebXVc6sNa09GYO3EbtUjshXIIBT66XMHDNwlmBAoRy9Tw==",
                            PhoneNumber = "(822) 597-0569 x22190",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5309c9cb-a531-4b79-a08c-b48a22da8875",
                            TwoFactorEnabled = false,
                            UserName = "Guadalupe_Jerde"
                        },
                        new
                        {
                            Id = "f1ac65b0-d535-487b-953d-03bcb5fe86ec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0da3bd90-27d3-4b42-bb7d-18574c1d13c3",
                            Email = "gail_lang86@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEDW/SLzjzh8eGdbfWJUe4Mysw+4EWmL7tD9v6W0eDX6BH+3L/7bkxbJ4ZnjnmVq/BA==",
                            PhoneNumber = "393.885.6613 x28676",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "13af97b9-df23-41ea-8bff-012a003f8806",
                            TwoFactorEnabled = false,
                            UserName = "Gail_Lang86"
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
