using OtoGaleriOtomasyon.Data;
using OtoGaleriOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleriOtomasyon.Forms
{
    public partial class CategoryFrom : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        Category cate = new Category();

        public CategoryFrom()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cate.Name = txtCategory.Text;
            cate.CreatedDate = Convert.ToDateTime(DateTime.Now.ToLocalTime());

            db.Categories.Add(cate);
            db.SaveChanges();
            txtCategory.Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryTool frmCate = new CategoryTool();
            frmCate.Show();
        }
    }
}
