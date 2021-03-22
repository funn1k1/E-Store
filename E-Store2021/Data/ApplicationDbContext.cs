using E_Store2021.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Store2021.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().ToTable("Category");

            modelBuilder.Entity<SubCategory>().ToTable("SubCategory");

            modelBuilder.Entity<Product>().ToTable("Product");

            modelBuilder.Entity<Company>().ToTable("Company");

            modelBuilder.Entity<Country>().ToTable("Country");

            modelBuilder.Entity<Review>().ToTable("Review");

            modelBuilder.Entity<Order>().ToTable("Order");

            modelBuilder.Entity<Coupon>().ToTable("Coupon");

            modelBuilder.Entity<ApplicationUser>().ToTable("User");

            modelBuilder.Entity<IdentityRole>().ToTable("Role");

            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");

            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");

            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");

            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");

            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
        }
    }
}