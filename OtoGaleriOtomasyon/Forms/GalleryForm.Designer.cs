namespace OtoGaleriOtomasyon.Forms
{
    partial class GalleryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalleryForm));
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.btnCarAdd = new System.Windows.Forms.Button();
            this.btnCarList = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomerAdd.BackgroundImage")));
            this.btnCustomerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerAdd.Location = new System.Drawing.Point(12, 12);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(106, 110);
            this.btnCustomerAdd.TabIndex = 1;
            this.btnCustomerAdd.Text = "Müşteri Ekle";
            this.btnCustomerAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomerList.BackgroundImage")));
            this.btnCustomerList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerList.Location = new System.Drawing.Point(124, 12);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(106, 110);
            this.btnCustomerList.TabIndex = 2;
            this.btnCustomerList.Text = "Müşteri Listele";
            this.btnCustomerList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomerList.UseVisualStyleBackColor = true;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // btnCarAdd
            // 
            this.btnCarAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarAdd.BackgroundImage")));
            this.btnCarAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCarAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarAdd.Location = new System.Drawing.Point(236, 12);
            this.btnCarAdd.Name = "btnCarAdd";
            this.btnCarAdd.Size = new System.Drawing.Size(106, 110);
            this.btnCarAdd.TabIndex = 3;
            this.btnCarAdd.Text = "Araç Kayıt";
            this.btnCarAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarAdd.UseVisualStyleBackColor = true;
            this.btnCarAdd.Click += new System.EventHandler(this.btnCarAdd_Click);
            // 
            // btnCarList
            // 
            this.btnCarList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarList.BackgroundImage")));
            this.btnCarList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarList.Location = new System.Drawing.Point(348, 12);
            this.btnCarList.Name = "btnCarList";
            this.btnCarList.Size = new System.Drawing.Size(106, 110);
            this.btnCarList.TabIndex = 4;
            this.btnCarList.Text = "Araç Listele";
            this.btnCarList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarList.UseVisualStyleBackColor = true;
            this.btnCarList.Click += new System.EventHandler(this.btnCarList_Click);
            // 
            // btnContract
            // 
            this.btnContract.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContract.BackgroundImage")));
            this.btnContract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContract.Location = new System.Drawing.Point(460, 12);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(106, 110);
            this.btnContract.TabIndex = 5;
            this.btnContract.Text = "Sözleşmeler";
            this.btnContract.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(572, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 110);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegister.Location = new System.Drawing.Point(684, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(106, 110);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Kullanıcı Kayıt";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnContract);
            this.Controls.Add(this.btnCarList);
            this.Controls.Add(this.btnCarAdd);
            this.Controls.Add(this.btnCustomerList);
            this.Controls.Add(this.btnCustomerAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GalleryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Galerisi Formu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Button btnCustomerList;
        private System.Windows.Forms.Button btnCarAdd;
        private System.Windows.Forms.Button btnCarList;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}