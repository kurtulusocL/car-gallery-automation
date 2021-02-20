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
    public partial class KayitForm : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        Register rgs = new Register();

        void Clear()
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }

        public KayitForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            rgs.Username = txtUsername.Text;
            rgs.Password = txtPassword.Text;
            rgs.CreatedDate = Convert.ToDateTime(DateTime.Now.ToLocalTime());

            db.Registers.Add(rgs);
            db.SaveChanges();
            Clear();
            dtGridUser.DataSource = db.Registers.OrderByDescending(i => i.CreatedDate).ToList();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            dtGridUser.DataSource = db.Registers.OrderByDescending(i => i.CreatedDate).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int registerId = (int)dtGridUser.CurrentRow.Cells["Id"].Value;
            rgs = db.Registers.FirstOrDefault(i => i.Id == registerId);

            db.Registers.Remove(rgs);
            db.SaveChanges();
            Clear();
            dtGridUser.DataSource = db.Registers.OrderByDescending(i => i.CreatedDate).ToList();
        }

        private void dtGridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridUser.CurrentRow;
            txtUsername.Text = row.Cells["Username"].Value.ToString();
            txtUsername.Tag = row.Cells["Id"].Value;
            txtPassword.Text = row.Cells["Password"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int registerId = (int)txtUsername.Tag;
            rgs = db.Registers.FirstOrDefault(i => i.Id == registerId);

            rgs.Username = txtUsername.Text;
            rgs.Password = txtPassword.Text;
            rgs.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToLocalTime());

            db.SaveChanges();
            Clear();
            dtGridUser.DataSource = db.Registers.OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }
    }
}
