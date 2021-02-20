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
    public partial class CustomerAdd : Form
    {
        ApplicationDbContext _db;
        Customer cust = new Customer();

        void Clear()
        {
            txtAdSoyad.Clear();
            txtKimlikNo.Clear();
            txtTelefon.Clear();
            rtextAdres.Clear();
            cmbBrand.SelectedValue = "";
            cmbKod.SelectedValue = "";
        }

        public CustomerAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CustomerTool frmTool = new CustomerTool();
            frmTool.Show();
        }

        private void CustomerAdd_Load(object sender, EventArgs e)
        {
            var carBrand = _db.Cars.Include("Contracts").Include("Category").Include("Customers").OrderByDescending(i => i.Customers.Count()).ToList();
            
            cmbBrand.DataSource = carBrand;
            cmbBrand.ValueMember = "Id";
            cmbBrand.DisplayMember = "Brand";

            var carCode = _db.Cars.Include("Contracts").Include("Category").Include("Customers").OrderByDescending(i => i.Customers.Count()).ToList();
            cmbKod.DataSource = carCode;
            cmbKod.ValueMember = "Id";
            cmbKod.DisplayMember = "CarCode";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cust.NameSurname = txtAdSoyad.Text;
            cust.PhoneNumber = txtTelefon.Text;
            cust.IdentityNo = txtKimlikNo.Text;
            cust.Birthdate = Convert.ToDateTime(dtDogum.Value);
            cust.Address = rtextAdres.Text;
            cust.CarId = (int)cmbBrand.SelectedValue;
            cust.CarId = (int)cmbKod.SelectedValue;
            cust.CreatedDate = Convert.ToDateTime(DateTime.Now.ToLocalTime());

            _db.Customers.Add(cust);
            _db.SaveChanges();
            Clear();
        }
    }
}
