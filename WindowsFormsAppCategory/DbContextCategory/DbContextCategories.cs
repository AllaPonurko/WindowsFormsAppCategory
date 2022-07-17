using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;
using WindowsFormsAppCategory.Models;

namespace WindowsFormsAppCategory.DbContextCategory
{
    public class DbContextCategories:DbContext
    {
        public DbSet<Category> Categories { get; set; } 
        public DbContextCategories() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
                           Database=DB_Category.db;Trusted_Connection=True;"); 
        }
    }
}
