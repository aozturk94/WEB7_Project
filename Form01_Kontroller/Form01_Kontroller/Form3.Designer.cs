
namespace Form01_Kontroller
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.rdnErkek = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lswKisiler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cinsiyet:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(89, 36);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Location = new System.Drawing.Point(89, 71);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(52, 17);
            this.rdbKadin.TabIndex = 3;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdnErkek
            // 
            this.rdnErkek.AutoSize = true;
            this.rdnErkek.Location = new System.Drawing.Point(89, 94);
            this.rdnErkek.Name = "rdnErkek";
            this.rdnErkek.Size = new System.Drawing.Size(53, 17);
            this.rdnErkek.TabIndex = 4;
            this.rdnErkek.TabStop = true;
            this.rdnErkek.Text = "Erkek";
            this.rdnErkek.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(89, 117);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lswKisiler
            // 
            this.lswKisiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lswKisiler.HideSelection = false;
            this.lswKisiler.Location = new System.Drawing.Point(195, 36);
            this.lswKisiler.Name = "lswKisiler";
            this.lswKisiler.Size = new System.Drawing.Size(186, 212);
            this.lswKisiler.TabIndex = 6;
            this.lswKisiler.UseCompatibleStateImageBehavior = false;
            this.lswKisiler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cinsiyet";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kurum";
            this.columnHeader3.Width = 56;
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(452, 35);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(100, 20);
            this.txtAranan.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aranan:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(452, 62);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 23);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(449, 98);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(41, 13);
            this.lblMesaj.TabIndex = 10;
            this.lblMesaj.Text = "Sonuç:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 357);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lswKisiler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.rdnErkek);
            this.Controls.Add(this.rdbKadin);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.RadioButton rdnErkek;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView lswKisiler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblMesaj;
    }
}