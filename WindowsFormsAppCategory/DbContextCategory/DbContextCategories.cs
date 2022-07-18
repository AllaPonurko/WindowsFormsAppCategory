using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;
using WindowsFormsAppCategory.Models;
using Microsoft.Data.Sqlite;

namespace WindowsFormsAppCategory.DbContextCategory
{
    public class DbContextCategories:DbContext
    {
        public DbSet<Category> Categories { get; set; } 
        
        //string connectionString = "Data Source = DatabaseCategory.db";

        public DbContextCategories()
        {  
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
                           Database=DatabaseCategory.db;Trusted_Connection=True;");

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite(connectionString);
            
        //}
    }
}
