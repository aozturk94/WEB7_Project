
namespace XYZBilisim.KayitSistemi
{
    partial class Form1
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
            this.dgvKayitSistemi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtEgiticiAdSoyad = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.rdbIceren = new System.Windows.Forms.RadioButton();
            this.rdbBaslayan = new System.Windows.Forms.RadioButton();
            this.rdbTam = new System.Windows.Forms.RadioButton();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKayitSistemi)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKayitSistemi
            // 
            this.dgvKayitSistemi.AllowUserToAddRows = false;
            this.dgvKayitSistemi.AllowUserToDeleteRows = false;
            this.dgvKayitSistemi.AllowUserToResizeColumns = false;
            this.dgvKayitSistemi.AllowUserToResizeRows = false;
            this.dgvKayitSistemi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKayitSistemi.Location = new System.Drawing.Point(285, 12);
            this.dgvKayitSistemi.Name = "dgvKayitSistemi";
            this.dgvKayitSistemi.ReadOnly = true;
            this.dgvKayitSistemi.RowHeadersVisible = false;
            this.dgvKayitSistemi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKayitSistemi.Size = new System.Drawing.Size(263, 172);
            this.dgvKayitSistemi.TabIndex = 0;
            this.dgvKayitSistemi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKayitSistemi_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğretici Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yıl:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(8, 28);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(128, 20);
            this.txtAdSoyad.TabIndex = 4;
            this.txtAdSoyad.Tag = "AdSoyad";
            // 
            // txtEgiticiAdSoyad
            // 
            this.txtEgiticiAdSoyad.Location = new System.Drawing.Point(8, 77);
            this.txtEgiticiAdSoyad.Name = "txtEgiticiAdSoyad";
            this.txtEgiticiAdSoyad.Size = new System.Drawing.Size(128, 20);
            this.txtEgiticiAdSoyad.TabIndex = 5;
            this.txtEgiticiAdSoyad.Tag = "EgiticiAdSoyad";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(8, 126);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(128, 20);
            this.txtYil.TabIndex = 6;
            this.txtYil.Tag = "Yil";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(15, 197);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(78, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(96, 197);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(78, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(177, 197);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(78, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.txtAdSoyad);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.txtYil);
            this.pnlControl.Controls.Add(this.txtEgiticiAdSoyad);
            this.pnlControl.Location = new System.Drawing.Point(15, 12);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(223, 172);
            this.pnlControl.TabIndex = 10;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(96, 255);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(78, 23);
            this.btnBul.TabIndex = 11;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(177, 226);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(78, 23);
            this.btnGetir.TabIndex = 12;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Location = new System.Drawing.Point(15, 226);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(78, 23);
            this.btnHepsiniSil.TabIndex = 13;
            this.btnHepsiniSil.Text = "HEPSİNİ SİL";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // rdbIceren
            // 
            this.rdbIceren.AutoSize = true;
            this.rdbIceren.Location = new System.Drawing.Point(96, 284);
            this.rdbIceren.Name = "rdbIceren";
            this.rdbIceren.Size = new System.Drawing.Size(55, 17);
            this.rdbIceren.TabIndex = 14;
            this.rdbIceren.Tag = "tagIceren";
            this.rdbIceren.Text = "İçeren";
            this.rdbIceren.UseVisualStyleBackColor = true;
            // 
            // rdbBaslayan
            // 
            this.rdbBaslayan.AutoSize = true;
            this.rdbBaslayan.Location = new System.Drawing.Point(96, 307);
            this.rdbBaslayan.Name = "rdbBaslayan";
            this.rdbBaslayan.Size = new System.Drawing.Size(82, 17);
            this.rdbBaslayan.TabIndex = 15;
            this.rdbBaslayan.Tag = "tagBaslayan";
            this.rdbBaslayan.Text = "İle Başlayan";
            this.rdbBaslayan.UseVisualStyleBackColor = true;
            // 
            // rdbTam
            // 
            this.rdbTam.AutoSize = true;
            this.rdbTam.Checked = true;
            this.rdbTam.Location = new System.Drawing.Point(96, 330);
            this.rdbTam.Name = "rdbTam";
            this.rdbTam.Size = new System.Drawing.Size(88, 17);
            this.rdbTam.TabIndex = 16;
            this.rdbTam.TabStop = true;
            this.rdbTam.Tag = "tagTam";
            this.rdbTam.Text = "Tam Eşleşme";
            this.rdbTam.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(96, 226);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 382);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.rdbTam);
            this.Controls.Add(this.rdbBaslayan);
            this.Controls.Add(this.rdbIceren);
            this.Controls.Add(this.btnHepsiniSil);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvKayitSistemi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKayitSistemi)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKayitSistemi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtEgiticiAdSoyad;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.RadioButton rdbIceren;
        private System.Windows.Forms.RadioButton rdbBaslayan;
        private System.Windows.Forms.RadioButton rdbTam;
        private System.Windows.Forms.Button btnTemizle;
    }
}

