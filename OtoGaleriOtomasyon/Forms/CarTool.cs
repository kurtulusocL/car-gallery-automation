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
    public partial class CarTool : Form
    {
        ApplicationDbContext _db;
        Car car = new Car();

        void Clear()
        {
            txtKm.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtRenk.Clear();
            txtToplamArac.Clear();
            txtYıl.Clear();
            cmbCate.SelectedValue = "";
            txtSearch.Clear();
            txtPrice.Clear();
        }

        public CarTool()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        void FormLoad()
        {
            var carList = _db.Cars.Where(i => i.IsDeleted == false).Select(i => new
            {
                i.Id,
                i.Brand,
                i.CarCode,
                i.Category.Name,
                i.Colour,
                i.KM,
                i.Model,
                i.Price.Value,
                i.TotalCar,
                i.Year,
                i.CreatedDate,
                i.UpdatedDate,
                i.CategoryId
            }).OrderByDescending(i => i.CreatedDate).ToList();
            dtGridCarList.DataSource = carList;
        }

        void UpdateTime()
        {
            var carList = _db.Cars.Where(i => i.IsDeleted == false).Select(i => new
            {
                i.Id,
                i.Brand,
                i.CarCode,
                i.Category.Name,
                i.Colour,
                i.KM,
                i.Model,
                i.Price.Value,
                i.TotalCar,
                i.Year,
                i.CreatedDate,
                i.UpdatedDate,
                i.CategoryId
            }).OrderByDescending(i => i.UpdatedDate.Value.ToString()).ToList();
            dtGridCarList.DataSource = carList;
        }

        private void CarTool_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtSearch, "Araç markasına göre arama yapabilirsiniz");
            FormLoad();
            var carCate = _db.Categories.Include("Contracts").Include("Cars").OrderByDescending(i => i.CreatedDate).ToList();
            cmbCate.DataSource = carCate;
            cmbCate.ValueMember = "Id";
            cmbCate.DisplayMember = "Name";
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                string Tahoma = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
                BaseFont bf = BaseFont.CreateFont(Tahoma, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                PdfPTable pdfTablosu = new PdfPTable(dtGridCarList.ColumnCount);
                pdfTablosu.DefaultCell.Padding = 3;
                pdfTablosu.WidthPercentage = 100;
                pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn sutun in dtGridCarList.Columns)
                {
                    PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText, new iTextSharp.text.Font(bf)));
                    pdfTablosu.AddCell(pdfHucresi);
                }
                foreach (DataGridViewRow satir in dtGridCarList.Rows)
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

        private void rdbKM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKM.Checked)
            {
                dtGridCarList.DataSource = _db.Cars.Include("Customers").Include("Category").Include("Contracts").OrderBy(i => i.KM).ToList();
            }
        }

        private void rdbFiyat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFiyat.Checked)
            {
                dtGridCarList.DataSource = _db.Cars.Include("Customers").Include("Category").Include("Contracts").OrderBy(i => i.Price.Value.ToString()).ToList();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtGridCarList.DataSource = _db.Cars.Where(i => i.Brand.Contains(txtSearch.Text)).ToList();
        }

        private void dtGridCarList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGridCarList.CurrentRow;
            txtMarka.Text = row.Cells["Brand"].Value.ToString();
            txtMarka.Tag = row.Cells["Id"].Value;
            txtKod.Text = row.Cells["CarCode"].Value.ToString();
            txtKm.Text = row.Cells["KM"].Value.ToString();
            txtModel.Text = row.Cells["Model"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            txtRenk.Text = row.Cells["Colour"].Value.ToString();
            txtToplamArac.Text = row.Cells["TotalCar"].Value.ToString();
            txtYıl.Text = row.Cells["Year"].Value.ToString();
            cmbCate.SelectedValue = row.Cells["CategoryId"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int carId = (int)txtMarka.Tag;
            car = _db.Cars.FirstOrDefault(i => i.Id == carId);

            car.Brand = txtMarka.Text;
            car.Model = txtModel.Text;
            car.CarCode = txtKod.Text;
            car.Colour = txtRenk.Text;
            car.KM = Convert.ToDouble(txtKm.Text);
            car.TotalCar = Convert.ToInt32(txtToplamArac.Text);
            car.Year = Convert.ToInt32(txtYıl.Text);
            car.CategoryId = (int)cmbCate.SelectedValue;
            car.Price = Convert.ToDecimal(txtPrice.Text);
            car.UpdatedDate = Convert.ToDateTime(DateTime.Now.ToLocalTime());

            _db.SaveChanges();
            Clear();
            UpdateTime();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int carId = (int)dtGridCarList.CurrentRow.Cells["Id"].Value;
            car = _db.Cars.Include("Customers").Include("Category").Include("Contracts").FirstOrDefault(i => i.Id == carId);

            _db.Cars.Remove(car);
            _db.SaveChanges();
            Clear();
            FormLoad();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kurtulusocal.com");
        }
    }
}
