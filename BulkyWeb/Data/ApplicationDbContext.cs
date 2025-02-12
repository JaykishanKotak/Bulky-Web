using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    // DbContext class is root class of entity fw core which  use to connect DB
    public class ApplicationDbContext : DbContext
    {
        // Connection string from appsetting.json
        // ctor for constructior
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        // db set to craete tab
        // To create table add-migration in Nugut console and do update-database to apply new migraation
        public DbSet<Category> Categories { get; set; }
    }
}
