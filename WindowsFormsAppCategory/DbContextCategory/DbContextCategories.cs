using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
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
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307;" +
            "username=root;/*password=root;*/database=DatabaseCategory");
        //string connectionString = "Data Source = DatabaseCategory.db";

        public DbContextCategories()
        {  
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3307;" +
             "username=root;database=databasecategory");
                //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
            //               Database=DatabaseCategory.db;Trusted_Connection=True;");

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite(connectionString);

        //}
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
