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
    public partial class CategoryTool : Form
    {
        ApplicationDbContext _db;
        Category cate = new Category();

        public CategoryTool()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        public string AracSayısı { get; set; }
        public string SozlesmeSayısı { get; set; }

        void FormLoad()
        {
            dtGridCategory.DataSource = _db.Categories.Where(i => i.IsDeleted == false).Select(i => new
            {
                i.Id,
                i.Name,
                Sayısı = i.Cars.Count,
                SozlesmeSayısı = i.Contracts.Count,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdateTime()
        {
            dtGridCategory.DataSource = _db.Categories.Where(i => i.IsDeleted == false).Select(i => new
            {
                i.Id,
                i.Name,
                Sayısı = i.Cars.Count,
                SozlesmeSayısı = i.Contracts.Count,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void CategoryTool_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void dtGridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridCategory.CurrentRow;
            txtCategory.Text = row.Cells["Name"].Value.ToString();
            txtCategory.Tag = row.Cells["Id"].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int cateId = (int)txtCategory.Tag;
            cate = _db.Categories.FirstOrDefault(i => i.Id == cateId);

            cate.Name = txtCategory.Text;
            cate.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToLocalTime());
            _db.SaveChanges();
            txtCategory.Clear();
            UpdateTime();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int cateId = (int)dtGridCategory.CurrentRow.Cells["Id"].Value;
            cate = _db.Categories.FirstOrDefault(i => i.Id == cateId);

            _db.Categories.Remove(cate);
            _db.SaveChanges();
            txtCategory.Clear();
            FormLoad();
        }
    }
}
