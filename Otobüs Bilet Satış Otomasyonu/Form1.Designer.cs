
namespace Otobüs_Bilet_Satış_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.nereyecb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.neredencb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rotalbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saat = new System.Windows.Forms.MaskedTextBox();
            this.tarih = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.telno = new System.Windows.Forms.MaskedTextBox();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OtobusBiletSatis = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(506, 114);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 23);
            this.textBox5.TabIndex = 7;
            // 
            // adsoyad
            // 
            this.adsoyad.Location = new System.Drawing.Point(211, 40);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(149, 23);
            this.adsoyad.TabIndex = 4;
            // 
            // nereyecb
            // 
            this.nereyecb.FormattingEnabled = true;
            this.nereyecb.Items.AddRange(new object[] {
            "Hatay",
            "İstanbul",
            "Ankara",
            "Elazığ",
            "Diyarbakır",
            "Konya",
            "Antalya"});
            this.nereyecb.Location = new System.Drawing.Point(135, 78);
            this.nereyecb.Name = "nereyecb";
            this.nereyecb.Size = new System.Drawing.Size(149, 23);
            this.nereyecb.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 100);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(111, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otobüs Bilet Satış Otomasyonu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adınız ve Soyadınız : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefon Numarası : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(392, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "T.C Kimlik : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(67, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Saat : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(62, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tarih : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(43, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nereye : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(30, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nereden : ";
            // 
            // neredencb
            // 
            this.neredencb.FormattingEnabled = true;
            this.neredencb.Items.AddRange(new object[] {
            "Hatay",
            "İstanbul",
            "Ankara",
            "Elazığ",
            "Diyarbakır",
            "Konya",
            "Antalya"});
            this.neredencb.Location = new System.Drawing.Point(135, 31);
            this.neredencb.Name = "neredencb";
            this.neredencb.Size = new System.Drawing.Size(149, 23);
            this.neredencb.TabIndex = 19;
            this.neredencb.SelectedIndexChanged += new System.EventHandler(this.neredencb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox1.Controls.Add(this.rotalbl);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.saat);
            this.groupBox1.Controls.Add(this.tarih);
            this.groupBox1.Controls.Add(this.nereyecb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.neredencb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 226);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet bilgileri";
            // 
            // rotalbl
            // 
            this.rotalbl.AutoSize = true;
            this.rotalbl.ForeColor = System.Drawing.Color.OliveDrab;
            this.rotalbl.Location = new System.Drawing.Point(304, 152);
            this.rotalbl.Name = "rotalbl";
            this.rotalbl.Size = new System.Drawing.Size(44, 15);
            this.rotalbl.TabIndex = 26;
            this.rotalbl.Text = "label10";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(290, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 25;
            this.button1.Text = "<>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saat
            // 
            this.saat.Location = new System.Drawing.Point(135, 182);
            this.saat.Mask = "90:00";
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(149, 23);
            this.saat.TabIndex = 24;
            this.saat.ValidatingType = typeof(System.DateTime);
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(135, 135);
            this.tarih.Mask = "00/00/0000";
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(149, 23);
            this.tarih.TabIndex = 23;
            this.tarih.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox2.Controls.Add(this.tc);
            this.groupBox2.Controls.Add(this.telno);
            this.groupBox2.Controls.Add(this.kaydetbtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.adsoyad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(422, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 226);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yolcu Bİlgileri";
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(211, 145);
            this.tc.Mask = "00000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(149, 23);
            this.tc.TabIndex = 25;
            this.tc.ValidatingType = typeof(int);
            // 
            // telno
            // 
            this.telno.Location = new System.Drawing.Point(211, 92);
            this.telno.Mask = "(999) 000-0000";
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(149, 23);
            this.telno.TabIndex = 24;
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kaydetbtn.Location = new System.Drawing.Point(211, 177);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(149, 43);
            this.kaydetbtn.TabIndex = 23;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "TC Kimlik Numarası : ";
            // 
            // OtobusBiletSatis
            // 
            this.OtobusBiletSatis.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtobusBiletSatis.FormattingEnabled = true;
            this.OtobusBiletSatis.ItemHeight = 34;
            this.OtobusBiletSatis.Location = new System.Drawing.Point(12, 401);
            this.OtobusBiletSatis.Name = "OtobusBiletSatis";
            this.OtobusBiletSatis.Size = new System.Drawing.Size(776, 174);
            this.OtobusBiletSatis.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.OtobusBiletSatis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.ComboBox nereyecb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox neredencb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox OtobusBiletSatis;
        private System.Windows.Forms.MaskedTextBox saat;
        private System.Windows.Forms.MaskedTextBox tarih;
        private System.Windows.Forms.MaskedTextBox tc;
        private System.Windows.Forms.MaskedTextBox telno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label rotalbl;
    }
}

