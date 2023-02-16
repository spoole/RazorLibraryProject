using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RazorLibraryProject.Models;
using Microsoft.AspNetCore.Identity;
using Bogus;

namespace RazorLibraryProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; } = default!;
        public DbSet<IdentityUser> UserAdmin { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<string> Guids = new List<string>(new string[] { Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = Guids[0], Name = "admin", NormalizedName = "ADMIN" });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = Guids[1], Name = "borrower", NormalizedName = "BORROWER" });
            PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
            ////We'll start with all the necessary info for a borrower and create a default borrower for demo purposes
            var basicBorrower = new IdentityUser
            {
                UserName = "borrower@library.net",
                NormalizedUserName = "borrower@library.net".ToLower(),
                Email = "borrower@library.net",
                NormalizedEmail = "borrower@library.net".ToLower(),
                Id = Guids[2],
                EmailConfirmed = true
            };
            basicBorrower.PasswordHash = hasher.HashPassword(basicBorrower, "(IAmBut1LowlyBorrower)");
            modelBuilder.Entity<IdentityUser>().HasData(basicBorrower);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId = Guids[1], UserId = Guids[2] });

            /////Then,the librarian, who will have the admin role
            var librarian = new IdentityUser
            {
                UserName = "librarian@library.net",
                NormalizedUserName = "librarian@library.net".ToLower(),
                NormalizedEmail = "librarian@library.net",
                Email = "librarian@library.net",
                Id = Guids[3],
                EmailConfirmed = true
            };
            librarian.PasswordHash = hasher.HashPassword(librarian, "(1DoesNotSimplyWalkIntoTheLibrary)");
            modelBuilder.Entity<IdentityUser>().HasData(librarian);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId = Guids[0], UserId = Guids[3] });

            //On to the regular users
            IdentityUser fakeBorrower = new IdentityUser();
            Faker<IdentityUser> user = new Faker<IdentityUser>().RuleFor(m => m.Id, f => Guid.NewGuid().ToString())
                .RuleFor(m => m.UserName, f => f.Person.UserName)
                .RuleFor(m => m.Email, f => f.Person.UserName.ToLower() + "@library.net")
                .RuleFor(m => m.PasswordHash, f => hasher.HashPassword(fakeBorrower, "(IAmBut1LowlyBorrower)"))
                .RuleFor(m => m.PhoneNumber, f => f.Person.Phone);

            modelBuilder.Entity<IdentityUser>().HasData(user.GenerateBetween(1, 20));

            //And some books
            Faker<Book> book = new Faker<Book>().RuleFor<int>(m => m.Id, f => ++f.IndexVariable)
                .RuleFor(m => m.Title, f => f.Company.CatchPhrase())
                .RuleFor(m => m.AuthorLast, f => f.Person.LastName)
                .RuleFor(m => m.AuthorFirst, f => f.Person.FirstName)
                .RuleFor(m => m.Description, f => f.Lorem.Paragraph())
                .RuleFor(m => m.isAvailable, f => f.Random.Bool());
            modelBuilder.Entity<Book>().HasData(book.GenerateBetween(10, 50));
        }
    }
}