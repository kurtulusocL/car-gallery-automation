using OtoGaleriOtomasyon.Data;
using OtoGaleriOtomasyon.Forms;
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

namespace OtoGaleriOtomasyon
{
    public partial class Form1 : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        Register rkayit = new Register();
        GalleryForm gallery = new GalleryForm();

        void Clear()
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            if ((rkayit.Username == txtUsername.Text) && (rkayit.Password == txtPassword.Text))
            {
                gallery.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifrenizi yanlış yazdınız. Eğer yetkili iseniz bilgilerinizi kontrol ederek yeniden deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
        }
    }
}
