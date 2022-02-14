
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cmbSehirler = new System.Windows.Forms.ComboBox();
            this.btnMesaj = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdbEvet = new System.Windows.Forms.RadioButton();
            this.rdbHayir = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.lblKopya.Size = new System.Drawing.Size(33, 13);
            this.lblKopya.TabIndex = 2;
            this.lblKopya.Text = "Label";
            // 
            // txtHarf
            // 
            this.txtHarf.Location = new System.Drawing.Point(170, 60);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(121, 20);
            this.txtHarf.TabIndex = 4;
            this.txtHarf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarf_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(167, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sadece Harf Girişi";
            // 
            // txtBuyukHarf
            // 
            this.txtBuyukHarf.Location = new System.Drawing.Point(297, 60);
            this.txtBuyukHarf.Name = "txtBuyukHarf";
            this.txtBuyukHarf.Size = new System.Drawing.Size(163, 20);
            this.txtBuyukHarf.TabIndex = 6;
            this.txtBuyukHarf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyukHarf_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(294, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sadece Büyük Harf Girişi";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(43, 147);
            this.maskedTextBox1.Mask = "LLL00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = '-';
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 22);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // cmbSehirler
            // 
            this.cmbSehirler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSehirler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSehirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSehirler.FormattingEnabled = true;
            this.cmbSehirler.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Bursa",
            "Adana",
            "Trabzon"});
            this.cmbSehirler.Location = new System.Drawing.Point(170, 147);
            this.cmbSehirler.Name = "cmbSehirler";
            this.cmbSehirler.Size = new System.Drawing.Size(120, 23);
            this.cmbSehirler.TabIndex = 8;
            this.cmbSehirler.SelectedIndexChanged += new System.EventHandler(this.cmbSehirler_SelectedIndexChanged);
            // 
            // btnMesaj
            // 
            this.btnMesaj.Location = new System.Drawing.Point(170, 186);
            this.btnMesaj.Name = "btnMesaj";
            this.btnMesaj.Size = new System.Drawing.Size(121, 23);
            this.btnMesaj.TabIndex = 9;
            this.btnMesaj.Text = "Mesaj";
            this.btnMesaj.UseVisualStyleBackColor = true;
            this.btnMesaj.Click += new System.EventHandler(this.btnMesaj_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Ali",
            "Ahmet",
            "Mustafa",
            "Ceylan",
            "Sezen",
            "Kemal",
            "Canan"});
            this.listBox1.Location = new System.Drawing.Point(296, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 147);
            this.listBox1.TabIndex = 10;
            // 
            // rdbEvet
            // 
            this.rdbEvet.AutoSize = true;
            this.rdbEvet.Location = new System.Drawing.Point(469, 88);
            this.rdbEvet.Name = "rdbEvet";
            this.rdbEvet.Size = new System.Drawing.Size(47, 17);
            this.rdbEvet.TabIndex = 11;
            this.rdbEvet.TabStop = true;
            this.rdbEvet.Text = "Evet";
            this.rdbEvet.UseVisualStyleBackColor = true;
            this.rdbEvet.CheckedChanged += new System.EventHandler(this.rdbEvet_CheckedChanged);
            this.rdbEvet.Click += new System.EventHandler(this.rdbEvet_Click);
            // 
            // rdbHayir
            // 
            this.rdbHayir.AutoSize = true;
            this.rdbHayir.Location = new System.Drawing.Point(542, 88);
            this.rdbHayir.Name = "rdbHayir";
            this.rdbHayir.Size = new System.Drawing.Size(49, 17);
            this.rdbHayir.TabIndex = 12;
            this.rdbHayir.TabStop = true;
            this.rdbHayir.Text = "Hayır";
            this.rdbHayir.UseVisualStyleBackColor = true;
            this.rdbHayir.CheckedChanged += new System.EventHandler(this.rdbHayir_CheckedChanged);
            this.rdbHayir.Click += new System.EventHandler(this.rdbHayir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(466, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Keyfin yerinde mi?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbErkek);
            this.groupBox1.Controls.Add(this.rdbKadin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(469, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 64);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Location = new System.Drawing.Point(6, 19);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(57, 19);
            this.rdbKadin.TabIndex = 0;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(6, 42);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(56, 19);
            this.rdbErkek.TabIndex = 1;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cevap:";
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(613, 164);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(50, 26);
            this.btnTamam.TabIndex = 16;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(43, 187);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(121, 23);
            this.btnForm2.TabIndex = 17;
            this.btnForm2.Text = "Form 2\'ye geç";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnForm2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 376);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbHayir);
            this.Controls.Add(this.rdbEvet);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMesaj);
            this.Controls.Add(this.cmbSehirler);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtBuyukHarf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHarf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKopya);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox cmbSehirler;
        private System.Windows.Forms.Button btnMesaj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rdbEvet;
        private System.Windows.Forms.RadioButton rdbHayir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnForm2;
    }
}

