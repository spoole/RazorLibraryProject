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
        public DbSet<User> User { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<string> Guids = new List<string>(new string[] { Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = Guids[0], Name = "admin", NormalizedName = "ADMIN" });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = Guids[1], Name = "borrower", NormalizedName = "BORROWER" });
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            ////We'll start with all the necessary info for a borrower and create a default borrower for demo purposes
            User basicBorrower = new User
            {
                UserName = "borrower@library.net",
                NormalizedUserName = "borrower@library.net".ToLower(),
                Email = "borrower@library.net",
                NormalizedEmail = "borrower@library.net".ToLower(),
                Id = Guids[2],
                EmailConfirmed = true
            };
            basicBorrower.PasswordHash = hasher.HashPassword(basicBorrower, "(IAmBut1LowlyBorrower)");
            modelBuilder.Entity<User>().HasData(basicBorrower);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId = Guids[1], UserId = Guids[2] });

            /////Then,the librarian, who will have the admin role
            User librarian = new User
            {
                UserName = "librarian@library.net",
                NormalizedUserName = "librarian@library.net".ToLower(),
                NormalizedEmail = "librarian@library.net",
                Email = "librarian@library.net",
                Id = Guids[3],
                EmailConfirmed = true
            };
            librarian.PasswordHash = hasher.HashPassword(librarian, "(1DoesNotSimplyWalkIntoTheLibrary)");
            modelBuilder.Entity<User>().HasData(librarian);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId = Guids[0], UserId = Guids[3] });

            //On to the regular users
            User fakeBorrower = new User();
            Faker<User> user = new Faker<User>().RuleFor(m => m.Id, f => Guid.NewGuid().ToString())
                .RuleFor(m => m.UserName, f => f.Person.UserName)
                .RuleFor(m => m.Email, f => f.Person.UserName.ToLower() + "@library.net")
                .RuleFor(m => m.PasswordHash, f => hasher.HashPassword(fakeBorrower, "(IAmBut1LowlyBorrower)"))
                .RuleFor(m => m.PhoneNumber, f => f.Person.Phone)
                .RuleFor(m => m.NormalizedUserName, f => f.Person.UserName.ToLower());

            modelBuilder.Entity<User>().HasData(user.GenerateBetween(1, 20));

            //And some books
            Faker<Book> book = new Faker<Book>().RuleFor<int>(m => m.Id, f => ++f.IndexVariable)
                .RuleFor(m => m.Title, f => f.Company.CatchPhrase())
                .RuleFor(m => m.AuthorLast, f => f.Person.LastName)
                .RuleFor(m => m.AuthorFirst, f => f.Person.FirstName)
                .RuleFor(m => m.Description, f => f.Lorem.Paragraph())
                .RuleFor(m => m.isAvailable, f => f.Random.Bool())
                .RuleFor(m => m.whoHas, f => "admin");
            modelBuilder.Entity<Book>().HasData(book.GenerateBetween(10, 50));
        }
    }
}