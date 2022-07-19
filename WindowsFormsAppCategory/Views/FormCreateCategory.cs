using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppCategory.Models;

namespace WindowsFormsAppCategory.Views
{
    public partial class FormCreateCategory : Form
    {
        public FormCreateCategory()
        {
            InitializeComponent();
        }
        //public FormCreateCategory(Form form)
        //{
        //    InitializeComponent();
        //}
        
        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNameCategory.Text!=null)
                {
                    FormCategory.data.NameCategory = txtNameCategory.Text;
                   
                }
           
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
