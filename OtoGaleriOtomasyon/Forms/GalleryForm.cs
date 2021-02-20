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
    public partial class GalleryForm : Form
    {
        public GalleryForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            KayitForm kayit = new KayitForm();
            kayit.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CategoryFrom cate = new CategoryFrom();
            cate.Show();
        }

        private void btnCarAdd_Click(object sender, EventArgs e)
        {
            CarAdd car = new CarAdd();
            car.Show();
        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            CarTool frmTool = new CarTool();
            frmTool.Show();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            CustomerAdd customer = new CustomerAdd();
            customer.Show();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            CustomerTool frmTool = new CustomerTool();
            frmTool.Show();
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            ContractForm contract = new ContractForm();
            contract.Show();
        }
    }
}
