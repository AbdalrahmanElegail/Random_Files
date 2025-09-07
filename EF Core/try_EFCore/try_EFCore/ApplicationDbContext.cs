using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using try_EFCore.Configurations;
using try_EFCore.Models;

namespace try_EFCore
{
    public class ApplicationDbContext : DbContext 
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore;Integrated Security=True");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BlogEntityTypeConfigurations().Configure(modelBuilder.Entity<Blog>());
        }


        public DbSet<Blog> Blogs { get; set; }

    }
}
