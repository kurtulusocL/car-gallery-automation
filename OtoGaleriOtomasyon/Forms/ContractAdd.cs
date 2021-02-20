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
    public partial class ContractAdd : Form
    {
        ApplicationDbContext _db;
        Contract cont = new Contract();

        void Clear()
        {
            txtDailyPrice.Clear();
            txtDay.Clear();
            txtTitle.Clear();
            cmbBrand.SelectedValue = "";
            cmbCarCode.SelectedValue = "";
            cmbCategory.SelectedValue = "";
            cmbModel.SelectedValue = "";
            cmbNameSurname.SelectedValue = "";
            label10.Text = "";
        }

        public ContractAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ContractForm cont = new ContractForm();
            cont.Show();
        }
        
        private void ContractAdd_Load(object sender, EventArgs e)
        {
            var cateList = _db.Categories.Include("Contracts").Include("Cars").Where(i => i.Cars.Count() > 0).OrderByDescending(i => i.CreatedDate).ToList();
            cmbCategory.DataSource = cateList;
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";

            var customerList = _db.Customers.Include("Contracts").Include("Car")./*Where(i => i.Contracts.Count > 0).*/OrderByDescending(i => i.CreatedDate).ToList();
            cmbNameSurname.DataSource = customerList;
            cmbNameSurname.ValueMember = "Id";
            cmbNameSurname.DisplayMember = "NameSurname";

            var carmodel = _db.Cars.Include("Contracts").Include("Customers").Include("Category").Where(i => i.Customers.Count() > 0 /*&& i.Contracts.Count() > 0*/).OrderByDescending(i => i.CreatedDate).ToList();
            cmbModel.DataSource = carmodel;
            cmbModel.ValueMember = "Id";
            cmbModel.DisplayMember = "Model";

            var carBrand = _db.Cars.Include("Contracts").Include("Customers").Include("Category").Where(i => i.Customers.Count() > 0 /*&& i.Contracts.Count() > 0*/).OrderByDescending(i => i.CreatedDate).ToList();
            cmbBrand.DataSource = carBrand;
            cmbBrand.ValueMember = "Id";
            cmbBrand.DisplayMember = "Brand";

            var carCode = _db.Cars.Include("Contracts").Include("Customers").Include("Category").Where(i => i.Customers.Count() > 0 /*&& i.Contracts.Count() > 0*/).OrderByDescending(i => i.CreatedDate).ToList();
            cmbCarCode.DataSource = carCode;
            cmbCarCode.ValueMember = "Id";
            cmbCarCode.DisplayMember = "CarCode";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cont.Title = txtTitle.Text;
            cont.DailyPrice = Convert.ToDecimal(txtDailyPrice.Text);
            cont.Day = Convert.ToInt32(txtDay.Text);
            cont.TotalPrice = (Convert.ToDecimal(txtDailyPrice.Text) * (Convert.ToInt32(txtDay.Text)));
            cont.CreatedDate = Convert.ToDateTime(DateTime.Now.ToLocalTime());           
            cont.CategoryId = (int)cmbCategory.SelectedIndex;           
            cont.CustomerId = (int)cmbNameSurname.SelectedIndex;           
            cont.CarId = (int)cmbBrand.SelectedIndex;           
            cont.CarId = (int)cmbCarCode.SelectedIndex;            

            _db.Contracts.Add(cont);
            _db.SaveChanges();
            Clear();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            cont.TotalPrice = (Convert.ToDecimal(txtDailyPrice.Text) * (Convert.ToInt32(txtDay.Text)));
            label10.Text = cont.TotalPrice.ToString();
        }
    }
}
