using CURDOperationWithImageUploadCore5_Demo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;

namespace CURDOperationWithImageUploadCore5_Demo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }
        public DbSet<Speaker> Speakers { get; set; }

        public DbSet<Products> Products { get; set; }
        public DbSet<ProductGallery> ProductGallery { get; set; }
        public DbSet<CategoryModel> Category { get; set; }
    }
}