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
    public partial class CarAdd : Form
    {
        ApplicationDbContext _db;
        Car car = new Car();
        Category cate = new Category();

        void Clear()
        {
            txtKm.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtRenk.Clear();
            txtToplamArac.Clear();
            txtYıl.Clear();
            cmbCate.SelectedValue = "";
            txtKod.Clear();
            txtPrice.Clear();
        }

        public CarAdd()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CarTool frmTool = new CarTool();
            frmTool.Show();
        }

        private void CarAdd_Load(object sender, EventArgs e)
        {
            var carCate = _db.Categories.Include("Cars").Include("Contracts").OrderByDescending(i => i.CreatedDate).ToList();

            cmbCate.DataSource = carCate;
            cmbCate.ValueMember = "Id";
            cmbCate.DisplayMember = "Name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            car.Brand = txtMarka.Text;
            car.Model = txtModel.Text;
            car.Colour = txtRenk.Text;
            car.KM = Convert.ToDouble(txtKm.Text);
            car.TotalCar = Convert.ToInt32(txtToplamArac.Text);
            car.Year = Convert.ToInt32(txtYıl.Text);
            car.CategoryId = (int)cmbCate.SelectedValue;
            car.Price = Convert.ToDecimal(txtPrice.Text);
            car.CarCode = txtKod.Text;
            car.CreatedDate = Convert.ToDateTime(DateTime.Now.ToLocalTime());

            _db.Cars.Add(car);
            _db.SaveChanges();
            Clear();
        }
    }
}
