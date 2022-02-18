
namespace WithClassSql_Crud2
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
            this.btnHastalar = new System.Windows.Forms.Button();
            this.btnBolumler = new System.Windows.Forms.Button();
            this.btnDoktorlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHastalar
            // 
            this.btnHastalar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHastalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastalar.Location = new System.Drawing.Point(77, 33);
            this.btnHastalar.Name = "btnHastalar";
            this.btnHastalar.Size = new System.Drawing.Size(214, 68);
            this.btnHastalar.TabIndex = 0;
            this.btnHastalar.Text = "HASTALAR";
            this.btnHastalar.UseVisualStyleBackColor = false;
            this.btnHastalar.Click += new System.EventHandler(this.btnHastalar_Click);
            // 
            // btnBolumler
            // 
            this.btnBolumler.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBolumler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumler.Location = new System.Drawing.Point(77, 134);
            this.btnBolumler.Name = "btnBolumler";
            this.btnBolumler.Size = new System.Drawing.Size(214, 68);
            this.btnBolumler.TabIndex = 1;
            this.btnBolumler.Text = "BÖLÜMLER";
            this.btnBolumler.UseVisualStyleBackColor = false;
            this.btnBolumler.Click += new System.EventHandler(this.btnBolumler_Click);
            // 
            // btnDoktorlar
            // 
            this.btnDoktorlar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDoktorlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorlar.Location = new System.Drawing.Point(77, 235);
            this.btnDoktorlar.Name = "btnDoktorlar";
            this.btnDoktorlar.Size = new System.Drawing.Size(214, 68);
            this.btnDoktorlar.TabIndex = 2;
            this.btnDoktorlar.Text = "DOKTORLAR";
            this.btnDoktorlar.UseVisualStyleBackColor = false;
            this.btnDoktorlar.Click += new System.EventHandler(this.btnDoktorlar_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 335);
            this.Controls.Add(this.btnDoktorlar);
            this.Controls.Add(this.btnBolumler);
            this.Controls.Add(this.btnHastalar);
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Otomasyonu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAna_FormClosing);
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHastalar;
        private System.Windows.Forms.Button btnBolumler;
        private System.Windows.Forms.Button btnDoktorlar;
    }
}

