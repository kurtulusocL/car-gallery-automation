using iTextSharp.text;
using iTextSharp.text.pdf;
using OtoGaleriOtomasyon.Data;
using OtoGaleriOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleriOtomasyon.Forms
{
    public partial class CustomerTool : Form
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
            txtSearch.Clear();
        }

        public CustomerTool()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        public string SozlesmeSayisi { get; set; }

        void FormLoad()
        {
            dtGridCustomer.DataSource = _db.Customers.Where(i => i.IsDeleted == false).Select(i => new
            {
                i.Id,
                i.IdentityNo,
                i.NameSurname,
                i.PhoneNumber,
                i.Car.CarCode,
                i.Car.Brand,
                i.Car.Model,
                i.CreatedDate,
                i.UpdatedDate,
                i.CarId,
                SozlesmeSayisi = i.Contracts.Count
            }).OrderByDescending(i=>i.CreatedDate).ToList();
        }

        void UpdateTime()
        {
            dtGridCustomer.DataSource = _db.Customers.Where(i => i.IsDeleted == false).Select(i => new
            {
                i.Id,
                i.IdentityNo,
                i.NameSurname,
                i.PhoneNumber,
                i.Car.CarCode,
                i.Car.Brand,
                i.Car.Model,
                i.CreatedDate,
                i.UpdatedDate,
                i.CarId,
                SozlesmeSayisi = i.Contracts.Count
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void CustomerTool_Load(object sender, EventArgs e)
        {
            FormLoad();

            var carBrand = _db.Cars.Include("Contracts").Include("Category").Include("Customers").OrderByDescending(i => i.Customers.Count()).ToList();
            cmbBrand.DataSource = carBrand;
            cmbBrand.ValueMember = "Id";
            cmbBrand.DisplayMember = "Brand";

            var carCode = _db.Cars.Include("Contracts").Include("Category").Include("Customers").OrderByDescending(i => i.Customers.Count()).ToList();
            cmbKod.DataSource = carCode;
            cmbKod.ValueMember = "Id";
            cmbKod.DisplayMember = "CarCode";

            toolTip1.SetToolTip(txtSearch, "Müşteri adı-soyadına göre arama yapabilirsiniz");
        }

        private void rdbAdSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAdSoyad.Checked)
            {
                dtGridCustomer.DataSource = _db.Customers.Include("Contracts").Include("Car").OrderBy(i => i.NameSurname).ToList();
            }
        }

        private void rdbDogum_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDogum.Checked)
            {
                dtGridCustomer.DataSource = _db.Customers.Include("Contracts").Include("Car").OrderBy(i => i.Birthdate.ToString()).ToList();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridCustomer.DataSource = _db.Customers.Include("Contracts").Include("Car").Where(i => i.NameSurname.Contains(txtSearch.Text)).ToList();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridCustomer.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridCustomer.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridCustomer.Rows)
                {
                    foreach (DataGridViewCell cell in satir.Cells)
                    {
                        pdfTablosu.AddCell(new Phrase(cell.Value.ToString(), new iTextSharp.text.Font(bf)));
                    }
                }

                SaveFileDialog dosyakaydet = new SaveFileDialog();
                dosyakaydet.FileName = "dosyaadı";
                dosyakaydet.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                dosyakaydet.Filter = "PDF Dosyası|*.pdf";
                if (dosyakaydet.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(dosyakaydet.FileName, FileMode.Create))
                    {

                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTablosu);
                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("PDF dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + dosyakaydet.FileName, "İşlem Tamam");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void dtGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridCustomer.CurrentRow;
            txtAdSoyad.Text = row.Cells["NameSurname"].Value.ToString();
            txtAdSoyad.Tag = row.Cells["Id"].Value;
            txtKimlikNo.Text = row.Cells["IdetityNo"].Value.ToString();
            txtTelefon.Text = row.Cells["PhoneNumber"].Value.ToString();
            dtDogum.Value = Convert.ToDateTime(row.Cells["Birthdate"].Value.ToString());
            rtextAdres.Text = row.Cells["Address"].Value.ToString();
            cmbBrand.SelectedValue = row.Cells["CarId"].Value.ToString();
            cmbKod.SelectedValue = row.Cells["CarId"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int customerId = (int)txtAdSoyad.Tag;
            cust = _db.Customers.FirstOrDefault(i => i.Id == customerId);

            cust.NameSurname = txtAdSoyad.Text;
            cust.PhoneNumber = txtTelefon.Text;
            cust.IdentityNo = txtKimlikNo.Text;
            cust.Birthdate = Convert.ToDateTime(dtDogum.Value);
            cust.Address = rtextAdres.Text;
            cust.CarId = (int)cmbBrand.SelectedValue;
            cust.CarId = (int)cmbKod.SelectedValue;
            cust.CreatedDate = Convert.ToDateTime(DateTime.Now.ToLocalTime());

            _db.SaveChanges();
            Clear();
            UpdateTime();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int customerId = (int)dtGridCustomer.CurrentRow.Cells["Id"].Value;
            cust = _db.Customers.FirstOrDefault(i => i.Id == customerId);

            _db.Customers.Remove(cust);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }
    }
}
