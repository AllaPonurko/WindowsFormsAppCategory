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
{ /// <summary>
/// структура для передачи данных из формы в форму
/// </summary>
    public struct DataCategory
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
    /// <summary>
    /// вызов формы для создания категории
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>    
        private void btnCategory_Click(object sender, EventArgs e)
        {
            Form form = new Views.FormCreateCategory();
            form.Show();
        }
/// <summary>
/// обновление перечня категорий
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void btnUpdateListCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.NameCategory.Length != 0)
                {
                    category = new Category();
                    listBoxCategoties.Items.Add(data.NameCategory);
                    category.Name = data.NameCategory;
                    Db.Categories.Add(category);
                    
                    data.NameCategory = null;
                }
                Db.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
/// <summary>
/// выход из приложения
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
/// <summary>
/// загрузка главной формы
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void FormCategory_Load(object sender, EventArgs e)
        {
            if (Db != null)
                foreach (var item in Db.Categories)
                    listBoxCategoties.Items.Add(item.ToString());
        }

        private void btnAddSubCategory_Click(object sender, EventArgs e)
        {
            if(listBoxCategoties.SelectedItem!=null)
            {
                Form form = new Views.FormCreateCategory();
                form.Show();
                
            }
        }
        /// <summary>
        /// обновление перечня подчинённых категорий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateListSubCat_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(listBoxCategoties.SelectedItem!=null&& data.NameCategory.Length != 0)
            {
                category = new Category();
                listBoxSubCategory.Items.Add(data.NameCategory);
                category.Name = data.NameCategory;
                foreach(var item in Db.Categories)
                {
                    if (listBoxCategoties.SelectedItem.ToString() == item.ToString())
                        item.Categories.Add(category);
                }
                Db.Categories.Add(category);
                data.NameCategory = null;
            }
                
                Db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
