
namespace Form01_Kontroller
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lblKopya = new System.Windows.Forms.Label();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuyukHarf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sadece Sayı Girişi";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(43, 60);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(121, 20);
            this.txtSayi.TabIndex = 1;
            this.txtSayi.TextChanged += new System.EventHandler(this.txtSayi_TextChanged);
            this.txtSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi_KeyPress);
            // 
            // lblKopya
            // 
            this.lblKopya.AutoSize = true;
            this.lblKopya.Location = new System.Drawing.Point(55, 105);
            this.lblKopya.Name = "lblKopya";
            this.lblKopya.Size = new System.Drawing.Size(0, 13);
            this.lblKopya.TabIndex = 2;
            // 
            // txtHarf
            // 
            this.txtHarf.Location = new System.Drawing.Point(266, 60);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(121, 20);
            this.txtHarf.TabIndex = 4;
            this.txtHarf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarf_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(263, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sadece Harf Girişi";
            // 
            // txtBuyukHarf
            // 
            this.txtBuyukHarf.Location = new System.Drawing.Point(466, 60);
            this.txtBuyukHarf.Name = "txtBuyukHarf";
            this.txtBuyukHarf.Size = new System.Drawing.Size(163, 20);
            this.txtBuyukHarf.TabIndex = 6;
            this.txtBuyukHarf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyukHarf_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(463, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sadece Büyük Harf Girişi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 364);
            this.Controls.Add(this.txtBuyukHarf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHarf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKopya);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label lblKopya;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuyukHarf;
        private System.Windows.Forms.Label label3;
    }
}

