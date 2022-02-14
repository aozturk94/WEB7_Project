
namespace Form_02_Sayi_Tahmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblHile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblHak = new System.Windows.Forms.Label();
            this.lblTahminler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(75, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahmin Giriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(75, 83);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(127, 20);
            this.txtTahmin.TabIndex = 0;
            this.txtTahmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTahmin_KeyDown);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(87, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(103, 33);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnTahmin
            // 
            this.btnTahmin.Location = new System.Drawing.Point(87, 121);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(103, 33);
            this.btnTahmin.TabIndex = 1;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(4, 167);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(268, 20);
            this.lblMesaj.TabIndex = 0;
            this.lblMesaj.Text = "Oyunu Başlatmak İçin BAŞLAT Butonunu Kullan";
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHile
            // 
            this.lblHile.AutoSize = true;
            this.lblHile.Location = new System.Drawing.Point(288, 170);
            this.lblHile.Name = "lblHile";
            this.lblHile.Size = new System.Drawing.Size(28, 13);
            this.lblHile.TabIndex = 3;
            this.lblHile.Text = "Hile:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(310, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Puan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(310, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hak";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPuan
            // 
            this.lblPuan.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.Color.Red;
            this.lblPuan.Location = new System.Drawing.Point(377, 12);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(70, 20);
            this.lblPuan.TabIndex = 0;
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHak
            // 
            this.lblHak.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHak.ForeColor = System.Drawing.Color.Red;
            this.lblHak.Location = new System.Drawing.Point(377, 51);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(70, 20);
            this.lblHak.TabIndex = 0;
            this.lblHak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTahminler
            // 
            this.lblTahminler.AutoSize = true;
            this.lblTahminler.Location = new System.Drawing.Point(223, 86);
            this.lblTahminler.Name = "lblTahminler";
            this.lblTahminler.Size = new System.Drawing.Size(0, 13);
            this.lblTahminler.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTahmin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 269);
            this.Controls.Add(this.lblTahminler);
            this.Controls.Add(this.lblHile);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sayı Tahmin Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblHile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label lblTahminler;
    }
}

