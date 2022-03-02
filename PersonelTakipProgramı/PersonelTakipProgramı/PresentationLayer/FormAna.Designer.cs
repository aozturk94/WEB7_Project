
namespace PersonelTakipProgramı
{
    partial class FormAna
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
            this.pnlAraclar = new System.Windows.Forms.Panel();
            this.dtpIseBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.cmbDurumu = new System.Windows.Forms.ComboBox();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlButonlar = new System.Windows.Forms.Panel();
            this.rdbTam = new System.Windows.Forms.RadioButton();
            this.rdbIceren = new System.Windows.Forms.RadioButton();
            this.rdbBaslangic = new System.Windows.Forms.RadioButton();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.pnlAraclar.SuspendLayout();
            this.pnlButonlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAraclar
            // 
            this.pnlAraclar.Controls.Add(this.dtpIseBaslamaTarihi);
            this.pnlAraclar.Controls.Add(this.dtpDogumTarihi);
            this.pnlAraclar.Controls.Add(this.cmbDepartman);
            this.pnlAraclar.Controls.Add(this.cmbDurumu);
            this.pnlAraclar.Controls.Add(this.cmbUnvan);
            this.pnlAraclar.Controls.Add(this.txtPersonelNo);
            this.pnlAraclar.Controls.Add(this.txtTcNo);
            this.pnlAraclar.Controls.Add(this.txtSoyad);
            this.pnlAraclar.Controls.Add(this.txtAd);
            this.pnlAraclar.Controls.Add(this.label7);
            this.pnlAraclar.Controls.Add(this.label8);
            this.pnlAraclar.Controls.Add(this.label9);
            this.pnlAraclar.Controls.Add(this.label4);
            this.pnlAraclar.Controls.Add(this.label5);
            this.pnlAraclar.Controls.Add(this.label6);
            this.pnlAraclar.Controls.Add(this.label3);
            this.pnlAraclar.Controls.Add(this.label2);
            this.pnlAraclar.Controls.Add(this.label1);
            this.pnlAraclar.Location = new System.Drawing.Point(14, 22);
            this.pnlAraclar.Name = "pnlAraclar";
            this.pnlAraclar.Size = new System.Drawing.Size(266, 245);
            this.pnlAraclar.TabIndex = 0;
            // 
            // dtpIseBaslamaTarihi
            // 
            this.dtpIseBaslamaTarihi.CalendarFont = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpIseBaslamaTarihi.Location = new System.Drawing.Point(107, 136);
            this.dtpIseBaslamaTarihi.Name = "dtpIseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.Size = new System.Drawing.Size(156, 20);
            this.dtpIseBaslamaTarihi.TabIndex = 5;
            this.dtpIseBaslamaTarihi.Tag = "IseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.ValueChanged += new System.EventHandler(this.dtpIseBaslamaTarihi_ValueChanged);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.CalendarFont = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDogumTarihi.Location = new System.Drawing.Point(107, 110);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(156, 20);
            this.dtpDogumTarihi.TabIndex = 4;
            this.dtpDogumTarihi.Tag = "DogumTarihi";
            this.dtpDogumTarihi.ValueChanged += new System.EventHandler(this.dtpDogumTarihi_ValueChanged);
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Muhasebe",
            "Satış",
            "Üretim",
            "Teknik"});
            this.cmbDepartman.Location = new System.Drawing.Point(107, 162);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(156, 21);
            this.cmbDepartman.TabIndex = 6;
            this.cmbDepartman.Tag = "Departman";
            // 
            // cmbDurumu
            // 
            this.cmbDurumu.FormattingEnabled = true;
            this.cmbDurumu.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cmbDurumu.Location = new System.Drawing.Point(107, 216);
            this.cmbDurumu.Name = "cmbDurumu";
            this.cmbDurumu.Size = new System.Drawing.Size(156, 21);
            this.cmbDurumu.TabIndex = 8;
            this.cmbDurumu.Tag = "Durumu";
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Items.AddRange(new object[] {
            "İşçi",
            "Ekip Lideri",
            "Yönetici Yardımcısı",
            "Yönetici"});
            this.cmbUnvan.Location = new System.Drawing.Point(107, 189);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(156, 21);
            this.cmbUnvan.TabIndex = 7;
            this.cmbUnvan.Tag = "Unvan";
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(107, 84);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(156, 20);
            this.txtPersonelNo.TabIndex = 3;
            this.txtPersonelNo.Tag = "PersonelNo";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(107, 58);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(156, 20);
            this.txtTcNo.TabIndex = 2;
            this.txtTcNo.Tag = "TcNo";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(107, 32);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(156, 20);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Tag = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(107, 6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(156, 20);
            this.txtAd.TabIndex = 0;
            this.txtAd.Tag = "Ad";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(3, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "DURUMU";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(3, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "ÜNVAN";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(3, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 14);
            this.label9.TabIndex = 6;
            this.label9.Text = "DEPARTMAN";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "İŞE B. TARİHİ";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(3, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "DOĞUM TARİHİ";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(3, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "PERSONEL NO";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC KİMLİK NO";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYADI";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI";
            // 
            // pnlButonlar
            // 
            this.pnlButonlar.Controls.Add(this.rdbTam);
            this.pnlButonlar.Controls.Add(this.rdbIceren);
            this.pnlButonlar.Controls.Add(this.rdbBaslangic);
            this.pnlButonlar.Controls.Add(this.btnBul);
            this.pnlButonlar.Controls.Add(this.btnGetir);
            this.pnlButonlar.Controls.Add(this.btnGuncelle);
            this.pnlButonlar.Controls.Add(this.btnKaydet);
            this.pnlButonlar.Controls.Add(this.btnHepsiniSil);
            this.pnlButonlar.Controls.Add(this.btnTemizle);
            this.pnlButonlar.Controls.Add(this.btnSil);
            this.pnlButonlar.Location = new System.Drawing.Point(14, 273);
            this.pnlButonlar.Name = "pnlButonlar";
            this.pnlButonlar.Size = new System.Drawing.Size(266, 114);
            this.pnlButonlar.TabIndex = 1;
            // 
            // rdbTam
            // 
            this.rdbTam.AutoSize = true;
            this.rdbTam.Checked = true;
            this.rdbTam.Location = new System.Drawing.Point(172, 90);
            this.rdbTam.Name = "rdbTam";
            this.rdbTam.Size = new System.Drawing.Size(88, 17);
            this.rdbTam.TabIndex = 20;
            this.rdbTam.TabStop = true;
            this.rdbTam.Text = "Tam Eşleşme";
            this.rdbTam.UseVisualStyleBackColor = true;
            // 
            // rdbIceren
            // 
            this.rdbIceren.AutoSize = true;
            this.rdbIceren.Location = new System.Drawing.Point(96, 90);
            this.rdbIceren.Name = "rdbIceren";
            this.rdbIceren.Size = new System.Drawing.Size(55, 17);
            this.rdbIceren.TabIndex = 19;
            this.rdbIceren.Text = "İçeren";
            this.rdbIceren.UseVisualStyleBackColor = true;
            // 
            // rdbBaslangic
            // 
            this.rdbBaslangic.AutoSize = true;
            this.rdbBaslangic.Location = new System.Drawing.Point(6, 90);
            this.rdbBaslangic.Name = "rdbBaslangic";
            this.rdbBaslangic.Size = new System.Drawing.Size(73, 17);
            this.rdbBaslangic.TabIndex = 18;
            this.rdbBaslangic.Text = "Başlangıcı";
            this.rdbBaslangic.UseVisualStyleBackColor = true;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBul.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.Location = new System.Drawing.Point(144, 61);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(119, 23);
            this.btnBul.TabIndex = 15;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGetir.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(3, 61);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(116, 23);
            this.btnGetir.TabIndex = 14;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(144, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(119, 23);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(3, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 23);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHepsiniSil.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.Location = new System.Drawing.Point(172, 32);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(91, 23);
            this.btnHepsiniSil.TabIndex = 13;
            this.btnHepsiniSil.Text = "HEPSİNİ SİL";
            this.btnHepsiniSil.UseVisualStyleBackColor = false;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTemizle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(96, 32);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(70, 23);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSil.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(3, 32);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.AllowUserToAddRows = false;
            this.dgvCalisanlar.AllowUserToDeleteRows = false;
            this.dgvCalisanlar.AllowUserToResizeColumns = false;
            this.dgvCalisanlar.AllowUserToResizeRows = false;
            this.dgvCalisanlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalisanlar.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvCalisanlar.Location = new System.Drawing.Point(286, 28);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.ReadOnly = true;
            this.dgvCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalisanlar.Size = new System.Drawing.Size(449, 329);
            this.dgvCalisanlar.TabIndex = 16;
            this.dgvCalisanlar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalisanlar_CellEnter);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 411);
            this.Controls.Add(this.dgvCalisanlar);
            this.Controls.Add(this.pnlButonlar);
            this.Controls.Add(this.pnlAraclar);
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wissen Akademie  PERSONEL TAKİP UYGULAMASI";
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.pnlAraclar.ResumeLayout(false);
            this.pnlAraclar.PerformLayout();
            this.pnlButonlar.ResumeLayout(false);
            this.pnlButonlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAraclar;
        private System.Windows.Forms.DateTimePicker dtpIseBaslamaTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.ComboBox cmbDurumu;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlButonlar;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private System.Windows.Forms.RadioButton rdbBaslangic;
        private System.Windows.Forms.RadioButton rdbIceren;
        private System.Windows.Forms.RadioButton rdbTam;
    }
}

