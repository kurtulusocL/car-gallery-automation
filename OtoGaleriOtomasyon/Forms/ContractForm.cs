using iTextSharp.text;
using iTextSharp.text.pdf;
using OtoGaleriOtomasyon.Data;
using OtoGaleriOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoGaleriOtomasyon.Forms
{
    public partial class ContractForm : Form
    {
        ApplicationDbContext _db;
        Contract cont = new Contract();

        void Clear()
        {
            txtDailyPrice.Clear();
            txtDay.Clear();
            txtSearch.Clear();
            txtTitle.Clear();
            cmbBrand.SelectedValue = "";
            cmbCarCode.SelectedValue = "";
            cmbCategory.SelectedValue = "";
            cmbModel.SelectedValue = "";
            cmbNameSurname.SelectedValue = "";
            label10.Text = "";
        }

        public ContractForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            dtGridContract.DataSource = _db.Contracts.Where(i => i.IsDeleted == false).Select(i => new
            {
                i.Id,
                i.Title,
                i.DailyPrice,
                i.Day,
                i.TotalPrice,
                i.Customer.NameSurname,
                i.Category.Name,
                i.Car.CarCode,
                i.Car.Model,
                i.Car.Brand,
                i.CarId,
                i.CategoryId,
                i.CustomerId,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.CreatedDate).ToList();
        }

        void UpdateTime()
        {
            dtGridContract.DataSource = _db.Contracts.Where(i => i.IsDeleted == false).Select(i => new
            {
                i.Id,
                i.Title,
                i.DailyPrice,
                i.Day,
                i.TotalPrice,
                i.Customer.NameSurname,
                i.Category.Name,
                i.Car.CarCode,
                i.Car.Model,
                i.Car.Brand,
                i.CarId,
                i.CategoryId,
                i.CustomerId,
                i.CreatedDate,
                i.UpdatedDate
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
        }

        private void btnShowContact_Click(object sender, EventArgs e)
        {
            ContractDetail detailFrom = new ContractDetail();
            detailFrom.Show();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            ContractAdd add = new ContractAdd();
            add.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Müşteri adı-soyadına göre arama yapınız");
            FormLoad();

            var cateList = _db.Categories.Include("Contracts").Include("Cars").Where(i => i.Cars.Count() > 0).OrderByDescending(i => i.CreatedDate).ToList();
            cmbCategory.DataSource = cateList;
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";

            var customerList = _db.Customers.Include("Contracts").Include("Car").Where(i => i.Contracts.Count > 0).OrderByDescending(i => i.CreatedDate).ToList();
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridContract.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridContract.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridContract.Rows)
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridContract.DataSource = _db.Contracts.Include("Customer").Include("Category").Include("Car").Where(i => i.Customer.NameSurname.Contains(txtSearch.Text)).ToList();
        }

        private void rdbNameSurname_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNameSurname.Checked)
            {
                dtGridContract.DataSource = _db.Contracts.Include("Customer").Include("Category").Include("Car").OrderBy(i => i.Customer.NameSurname).ToList();
            }
        }

        private void rdbPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPrice.Checked)
            {
                dtGridContract.DataSource = _db.Contracts.Include("Customer").Include("Category").Include("Car").OrderBy(i => i.Car.Price.Value.ToString()).ToList();
            }
        }

        private void rdbTotalPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPrice.Checked)
            {
                dtGridContract.DataSource = _db.Contracts.Include("Customer").Include("Category").Include("Car").OrderBy(i => i.TotalPrice.ToString()).ToList();
            }
        }

        private void rdbDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDay.Checked)
            {
                dtGridContract.DataSource = _db.Contracts.Include("Customer").Include("Category").Include("Car").OrderBy(i => i.Day.ToString()).ToList();
            }
        }

        private void dtGridContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridContract.CurrentRow;
            txtTitle.Text = row.Cells["Title"].Value.ToString();
            txtTitle.Tag = row.Cells["Id"].Value.ToString();
            txtDay.Text = row.Cells["Day"].Value.ToString();
            txtDailyPrice.Text = row.Cells["DailyPrice"].Value.ToString();
            cmbBrand.SelectedValue = row.Cells["CarId"].Value.ToString();
            cmbCarCode.SelectedValue = row.Cells["CarId"].Value.ToString();
            cmbCategory.SelectedValue = row.Cells["CategoryId"].Value.ToString();
            cmbModel.SelectedValue = row.Cells["CarId"].Value.ToString();
            cmbNameSurname.SelectedValue = row.Cells["CustomerId"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var contractId = (int)txtTitle.Tag;
            cont = _db.Contracts.FirstOrDefault(i => i.Id == contractId);

            cont.Title = txtTitle.Text;
            cont.DailyPrice = Convert.ToDecimal(txtDailyPrice.Text);
            cont.Day = Convert.ToInt32(txtDay.Text);
            cont.TotalPrice = (Convert.ToDecimal(txtDailyPrice.Text) * (Convert.ToInt32(txtDay.Text)));
            cont.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToLocalTime());
            cont.CategoryId = (int)cmbCategory.SelectedValue;
            cont.CustomerId = (int)cmbNameSurname.SelectedValue;
            cont.CarId = (int)cmbBrand.SelectedValue;
            cont.CarId = (int)cmbCarCode.SelectedValue;

            _db.SaveChanges();
            Clear();
            UpdateTime();
        }

        private void label10_DoubleClick(object sender, EventArgs e)
        {
            cont.TotalPrice = (Convert.ToDecimal(txtDailyPrice.Text) * (Convert.ToInt32(txtDay.Text)));
            label10.Text = cont.TotalPrice.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int contractId = (int)dtGridContract.CurrentRow.Cells["Id"].Value;
            cont = _db.Contracts.FirstOrDefault(i => i.Id == contractId);

            _db.Contracts.Remove(cont);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }
    }
}
