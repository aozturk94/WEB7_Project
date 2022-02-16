
namespace Form01_Kontroller
{
    partial class Form4
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
            this.lblSayi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lstKazananlar = new System.Windows.Forms.ListBox();
            this.rdbTek = new System.Windows.Forms.RadioButton();
            this.rdbCift = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblSayi
            // 
            this.lblSayi.BackColor = System.Drawing.Color.Tomato;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi.ForeColor = System.Drawing.Color.SeaShell;
            this.lblSayi.Location = new System.Drawing.Point(108, 76);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(277, 180);
            this.lblSayi.TabIndex = 0;
            this.lblSayi.Text = "100";
            this.lblSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSayi.Click += new System.EventHandler(this.lblSayi_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(123, 275);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(35, 13);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "label1";
            // 
            // lstKazananlar
            // 
            this.lstKazananlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstKazananlar.FormattingEnabled = true;
            this.lstKazananlar.ItemHeight = 16;
            this.lstKazananlar.Location = new System.Drawing.Point(403, 76);
            this.lstKazananlar.Name = "lstKazananlar";
            this.lstKazananlar.Size = new System.Drawing.Size(79, 180);
            this.lstKazananlar.TabIndex = 2;
            // 
            // rdbTek
            // 
            this.rdbTek.AutoSize = true;
            this.rdbTek.Location = new System.Drawing.Point(17, 76);
            this.rdbTek.Name = "rdbTek";
            this.rdbTek.Size = new System.Drawing.Size(46, 17);
            this.rdbTek.TabIndex = 3;
            this.rdbTek.TabStop = true;
            this.rdbTek.Text = "TEK";
            this.rdbTek.UseVisualStyleBackColor = true;
            this.rdbTek.CheckedChanged += new System.EventHandler(this.rdbTek_CheckedChanged);
            // 
            // rdbCift
            // 
            this.rdbCift.AutoSize = true;
            this.rdbCift.Location = new System.Drawing.Point(17, 99);
            this.rdbCift.Name = "rdbCift";
            this.rdbCift.Size = new System.Drawing.Size(48, 17);
            this.rdbCift.TabIndex = 4;
            this.rdbCift.TabStop = true;
            this.rdbCift.Text = "ÇİFT";
            this.rdbCift.UseVisualStyleBackColor = true;
            this.rdbCift.CheckedChanged += new System.EventHandler(this.rdbCift_CheckedChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 371);
            this.Controls.Add(this.rdbCift);
            this.Controls.Add(this.rdbTek);
            this.Controls.Add(this.lstKazananlar);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblSayi);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.ListBox lstKazananlar;
        private System.Windows.Forms.RadioButton rdbTek;
        private System.Windows.Forms.RadioButton rdbCift;
    }
}