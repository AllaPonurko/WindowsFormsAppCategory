using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppCategory.DbContextCategory;
using WindowsFormsAppCategory.Models;

namespace WindowsFormsAppCategory
{ public struct DataCategory
    {
        public string NameCategory { get; set; }
    }
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }
        static public DataCategory data = new DataCategory();
        public Category category;
        static public  DbContextCategories Db =new DbContextCategories();
        private void btnCategory_Click(object sender, EventArgs e)
        {
            Form form = new Views.FormCreateCategory(this);
            form.Show();
        }

        private void btnUpdateListCat_Click(object sender, EventArgs e)
        {if (data.NameCategory.Length!=0)
            {
                category = new Category();
                listBoxCategoties.Items.Add(data.NameCategory);
                category.Name = data.NameCategory;
                Db.Add(category);
                Db.SaveChanges();
                data.NameCategory.Remove(data.NameCategory.Count());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            if (Db != null)
                foreach (var item in Db.Categories)
                    listBoxCategoties.Items.Add(item.ToString());
        }
    }
}
