namespace OtoGaleriOtomasyon.Forms
{
    partial class ContractForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDailyPrice = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbNameSurname = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCarCode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdbNameSurname = new System.Windows.Forms.RadioButton();
            this.rdbPrice = new System.Windows.Forms.RadioButton();
            this.rdbTotalPrice = new System.Windows.Forms.RadioButton();
            this.rdbDay = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShowContact = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtGridContract = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridContract)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sözleşme Başlığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat / Kiralık - Satış";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.Location = new System.Drawing.Point(120, 329);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(168, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtDailyPrice
            // 
            this.txtDailyPrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDailyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDailyPrice.Location = new System.Drawing.Point(120, 382);
            this.txtDailyPrice.Multiline = true;
            this.txtDailyPrice.Name = "txtDailyPrice";
            this.txtDailyPrice.Size = new System.Drawing.Size(168, 20);
            this.txtDailyPrice.TabIndex = 3;
            // 
            // txtDay
            // 
            this.txtDay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDay.Location = new System.Drawing.Point(120, 408);
            this.txtDay.Multiline = true;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(168, 20);
            this.txtDay.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kira Süresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Satış / Kiralık";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(120, 355);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(168, 21);
            this.cmbCategory.TabIndex = 2;
            // 
            // cmbNameSurname
            // 
            this.cmbNameSurname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbNameSurname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameSurname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbNameSurname.FormattingEnabled = true;
            this.cmbNameSurname.Location = new System.Drawing.Point(420, 329);
            this.cmbNameSurname.Name = "cmbNameSurname";
            this.cmbNameSurname.Size = new System.Drawing.Size(168, 21);
            this.cmbNameSurname.TabIndex = 5;
            // 
            // cmbBrand
            // 
            this.cmbBrand.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(420, 356);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(168, 21);
            this.cmbBrand.TabIndex = 6;
            // 
            // cmbModel
            // 
            this.cmbModel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(420, 383);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(168, 21);
            this.cmbModel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Müşteri Adı-Soyadı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Araç Markası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Araç Modeli";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Araç Kodu";
            // 
            // cmbCarCode
            // 
            this.cmbCarCode.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbCarCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCarCode.FormattingEnabled = true;
            this.cmbCarCode.Location = new System.Drawing.Point(420, 410);
            this.cmbCarCode.Name = "cmbCarCode";
            this.cmbCarCode.Size = new System.Drawing.Size(168, 21);
            this.cmbCarCode.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(637, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Arama Yap";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(702, 329);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rdbNameSurname
            // 
            this.rdbNameSurname.AutoSize = true;
            this.rdbNameSurname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbNameSurname.Location = new System.Drawing.Point(702, 356);
            this.rdbNameSurname.Name = "rdbNameSurname";
            this.rdbNameSurname.Size = new System.Drawing.Size(143, 17);
            this.rdbNameSurname.TabIndex = 14;
            this.rdbNameSurname.TabStop = true;
            this.rdbNameSurname.Text = "Müşreri Adına Göre Sırala";
            this.rdbNameSurname.UseVisualStyleBackColor = true;
            this.rdbNameSurname.CheckedChanged += new System.EventHandler(this.rdbNameSurname_CheckedChanged);
            // 
            // rdbPrice
            // 
            this.rdbPrice.AutoSize = true;
            this.rdbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbPrice.Location = new System.Drawing.Point(702, 379);
            this.rdbPrice.Name = "rdbPrice";
            this.rdbPrice.Size = new System.Drawing.Size(107, 17);
            this.rdbPrice.TabIndex = 15;
            this.rdbPrice.TabStop = true;
            this.rdbPrice.Text = "Fiyata Göre Sırala";
            this.rdbPrice.UseVisualStyleBackColor = true;
            this.rdbPrice.CheckedChanged += new System.EventHandler(this.rdbPrice_CheckedChanged);
            // 
            // rdbTotalPrice
            // 
            this.rdbTotalPrice.AutoSize = true;
            this.rdbTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbTotalPrice.Location = new System.Drawing.Point(702, 402);
            this.rdbTotalPrice.Name = "rdbTotalPrice";
            this.rdbTotalPrice.Size = new System.Drawing.Size(145, 17);
            this.rdbTotalPrice.TabIndex = 16;
            this.rdbTotalPrice.TabStop = true;
            this.rdbTotalPrice.Text = "Toplam Fiyata Göre Sırala";
            this.rdbTotalPrice.UseVisualStyleBackColor = true;
            this.rdbTotalPrice.CheckedChanged += new System.EventHandler(this.rdbTotalPrice_CheckedChanged);
            // 
            // rdbDay
            // 
            this.rdbDay.AutoSize = true;
            this.rdbDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbDay.Location = new System.Drawing.Point(702, 425);
            this.rdbDay.Name = "rdbDay";
            this.rdbDay.Size = new System.Drawing.Size(141, 17);
            this.rdbDay.TabIndex = 17;
            this.rdbDay.TabStop = true;
            this.rdbDay.Text = "Kira Süresine Göre Sırala";
            this.rdbDay.UseVisualStyleBackColor = true;
            this.rdbDay.CheckedChanged += new System.EventHandler(this.rdbDay_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(432, 443);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 74);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(351, 443);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 74);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShowContact
            // 
            this.btnShowContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowContact.BackgroundImage")));
            this.btnShowContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowContact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowContact.Location = new System.Drawing.Point(513, 443);
            this.btnShowContact.Name = "btnShowContact";
            this.btnShowContact.Size = new System.Drawing.Size(75, 74);
            this.btnShowContact.TabIndex = 10;
            this.btnShowContact.UseVisualStyleBackColor = true;
            this.btnShowContact.Click += new System.EventHandler(this.btnShowContact_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddContact.BackgroundImage")));
            this.btnAddContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddContact.Location = new System.Drawing.Point(270, 443);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(75, 74);
            this.btnAddContact.TabIndex = 9;
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(757, 470);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Uyarı";
            // 
            // dtGridContract
            // 
            this.dtGridContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridContract.Location = new System.Drawing.Point(-1, 1);
            this.dtGridContract.Name = "dtGridContract";
            this.dtGridContract.Size = new System.Drawing.Size(858, 322);
            this.dtGridContract.TabIndex = 26;
            this.dtGridContract.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridContract_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(117, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Fiyatı Hesapla";
            this.label10.DoubleClick += new System.EventHandler(this.label10_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Toplam Fiyat";
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Location = new System.Drawing.Point(594, 443);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 74);
            this.btnPdf.TabIndex = 29;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(858, 527);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtGridContract);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.btnShowContact);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rdbDay);
            this.Controls.Add(this.rdbTotalPrice);
            this.Controls.Add(this.rdbPrice);
            this.Controls.Add(this.rdbNameSurname);
            this.Controls.Add(this.cmbCarCode);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.cmbNameSurname);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtDailyPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Satış - Kiralama Sözleşmeleri";
            this.Load += new System.EventHandler(this.ContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDailyPrice;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbNameSurname;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCarCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdbNameSurname;
        private System.Windows.Forms.RadioButton rdbPrice;
        private System.Windows.Forms.RadioButton rdbTotalPrice;
        private System.Windows.Forms.RadioButton rdbDay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShowContact;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dtGridContract;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPdf;
    }
}