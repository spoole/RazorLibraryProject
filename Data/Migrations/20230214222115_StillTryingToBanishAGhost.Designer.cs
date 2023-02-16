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
    [Migration("20230214222115_StillTryingToBanishAGhost")]
    partial class StillTryingToBanishAGhost
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
                            Id = "676b2a08-cbb1-49d3-b228-1cab7d907e2e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fc13fe06-5689-42e2-af2d-e2ced785b907",
                            Email = "lucas.rogahn17@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAECIschFVry4inVPxUxOlFnlCzF83TYC7Ktx3pqHfmrleHoNe60g37wxx3twnEXjiJA==",
                            PhoneNumber = "201-426-7674",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d9bc68ff-748f-4340-a0dc-891adef4a1f3",
                            TwoFactorEnabled = false,
                            UserName = "Lucas.Rogahn17"
                        },
                        new
                        {
                            Id = "2e2125bf-8d24-4a67-ac50-f6cc0e4f9900",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6418428b-d8ae-4327-8ef0-32238045c703",
                            Email = "shelia71@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEBL5yVo2ujd+AYRYMgP2G7iiYNmK4PU6j9Y1B5n8+4N8t8dIGLFLuM9+IKxLEGe4Gw==",
                            PhoneNumber = "380-506-7117 x10421",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "71cee0b2-851d-480a-ac01-5ae3dff11e26",
                            TwoFactorEnabled = false,
                            UserName = "Shelia71"
                        },
                        new
                        {
                            Id = "30993f15-8f91-4846-9560-d5078695aa21",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "542558e6-954d-4b93-8e16-3ed531d90c42",
                            Email = "blanca76@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEHf+nVGL9xmvYk0srZcfd5wGddeev6F0cms34dXYEAI3PIk/o5dP5sEpDMEdyuXvCA==",
                            PhoneNumber = "975-693-3701 x88783",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b485fcd0-2ff2-4fa8-98d6-5b9f801315db",
                            TwoFactorEnabled = false,
                            UserName = "Blanca76"
                        },
                        new
                        {
                            Id = "5bb60d79-ac4f-44c5-9fb6-fde7a76b0740",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "72c2e89b-d92d-47a4-9d81-522ace4965a9",
                            Email = "ricky_effertz@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEKDNx9lDoufytIRskq7RBwdA6tnuo58UYLBqywSit51kOh9Q7n//a8iHFMSnYSM9rw==",
                            PhoneNumber = "273.722.9536",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ff6680d4-c772-4537-81b5-c61a1c6a70ca",
                            TwoFactorEnabled = false,
                            UserName = "Ricky_Effertz"
                        },
                        new
                        {
                            Id = "e39c8685-9c1f-4a75-9e86-898219b7c6b1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1a922383-5ad7-4241-8d8a-9636baf2c306",
                            Email = "kristine0@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAECgcnxI1L47vWy73pZqwE0GY6JEbVaY+FAge/eTaKZuR9rFAE+9zmm9AIDr6Ewv6qQ==",
                            PhoneNumber = "(365) 309-5607",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dd44d3f7-50af-4389-912b-e06a4aeebd78",
                            TwoFactorEnabled = false,
                            UserName = "Kristine0"
                        },
                        new
                        {
                            Id = "e90528a2-275c-4622-8049-1bee9a8cd017",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "73261beb-609d-42fb-9539-0b52cf1f26f6",
                            Email = "randy_hegmann0@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEAI1I9Ag29fmDNsdSuvP5jihik8TAo/IwVY2rp64jBsu2NireYnkem3LqRQBFAWpsA==",
                            PhoneNumber = "827-439-8278",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0b29048d-b64e-4ef8-aa16-a4a6532302a1",
                            TwoFactorEnabled = false,
                            UserName = "Randy_Hegmann0"
                        },
                        new
                        {
                            Id = "73063a80-ae2c-40fd-aec2-50cf6e6bd432",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c8e31804-e128-42c7-99d2-47fbf50cc751",
                            Email = "toby96@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEAgTaV3bh+pAXLc2lxuYX+RQGJhekpEjbt0/Lz7Boax5g6RMH9hI/iYhmpwDfUsZcg==",
                            PhoneNumber = "1-963-836-1200 x342",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "35de3439-fb7f-484a-b649-3a8f41f7ae0f",
                            TwoFactorEnabled = false,
                            UserName = "Toby96"
                        },
                        new
                        {
                            Id = "d978303b-28bc-4f7b-bda8-c92f4d350725",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9b492821-4b5c-49c8-92dc-2b2bfc67c774",
                            Email = "paulette.stiedemann99@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEPSdtgK3dYOtCilkA6BPae4kUHOfW2CzRyP0TUGlSHTR86CG6LRw6vV+giexSY2FNQ==",
                            PhoneNumber = "1-522-236-7877",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4e39ae4a-a7cc-4987-a029-2f503fa86199",
                            TwoFactorEnabled = false,
                            UserName = "Paulette.Stiedemann99"
                        },
                        new
                        {
                            Id = "dbe27119-b95d-4fec-8566-c1752ec7beea",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7a6dea2e-8ff8-4b9e-905a-722f8c985670",
                            Email = "seth_lueilwitz29@library.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEKLW43miKVVE9dHxCHPt9DI4w9rwYllemh854W3GsyoNxKUNZ4BXf8sIrg6qxXatNw==",
                            PhoneNumber = "1-477-302-0434 x39703",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "039c4257-f3bf-49b7-bf90-2e94807ed7ef",
                            TwoFactorEnabled = false,
                            UserName = "Seth_Lueilwitz29"
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