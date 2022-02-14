
namespace Form01_Kontroller
{
    partial class Form2
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(108, 36);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            this.txtAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(214, 36);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.Location = new System.Drawing.Point(108, 62);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(99, 121);
            this.lstKisiler.TabIndex = 3;
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(105, 186);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(35, 13);
            this.lblKisiSayisi.TabIndex = 4;
            this.lblKisiSayisi.Text = "label2";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(539, 39);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 23);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(433, 39);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(100, 20);
            this.txtAranan.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aranan Ad Soyad:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(430, 73);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(44, 13);
            this.lblSonuc.TabIndex = 8;
            this.lblSonuc.Text = "Aranan:";
            this.lblSonuc.Click += new System.EventHandler(this.lblSonuc_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 375);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKisiSayisi);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSonuc;
    }
}