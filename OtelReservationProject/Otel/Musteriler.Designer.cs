namespace Otel
{
    partial class Musteriler
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            BtnVerileriGoster = new Button();
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnAra = new Button();
            button4 = new Button();
            CmbCinsiyet = new ComboBox();
            DtpCıkısTarih = new DateTimePicker();
            DtpGiristarih = new DateTimePicker();
            TxtOdaNo = new TextBox();
            TxtUcret = new TextBox();
            TxtAd = new TextBox();
            TxtKimlikNo = new TextBox();
            TxtMail = new TextBox();
            TxtSoyad = new TextBox();
            MskTxtTelefon = new MaskedTextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label12 = new Label();
            BtnTemizle = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            listView1.Location = new Point(3, 282);
            listView1.Name = "listView1";
            listView1.Size = new Size(1019, 211);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DoubleClick += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cinsiyet";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mail";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TC";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "OdaNo";
            columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ucret";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "GirisTarihi";
            columnHeader10.Width = 110;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "CikisTarihi";
            columnHeader11.Width = 110;
            // 
            // BtnVerileriGoster
            // 
            BtnVerileriGoster.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            BtnVerileriGoster.Location = new Point(898, 9);
            BtnVerileriGoster.Name = "BtnVerileriGoster";
            BtnVerileriGoster.Size = new Size(124, 29);
            BtnVerileriGoster.TabIndex = 1;
            BtnVerileriGoster.Text = "Verileri Göster";
            BtnVerileriGoster.UseVisualStyleBackColor = true;
            BtnVerileriGoster.Click += button1_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            BtnGuncelle.Location = new Point(898, 50);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(124, 29);
            BtnGuncelle.TabIndex = 2;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            BtnSil.Location = new Point(898, 94);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(124, 29);
            BtnSil.TabIndex = 3;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnAra
            // 
            BtnAra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            BtnAra.Location = new Point(898, 173);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(124, 29);
            BtnAra.TabIndex = 4;
            BtnAra.Text = "Ara";
            BtnAra.UseVisualStyleBackColor = true;
            BtnAra.Click += BtnAra_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button4.Location = new Point(786, 59);
            button4.Name = "button4";
            button4.Size = new Size(82, 31);
            button4.TabIndex = 44;
            button4.Text = "Hesapla";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Bay", "Bayan" });
            CmbCinsiyet.Location = new Point(137, 101);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(251, 28);
            CmbCinsiyet.TabIndex = 43;
            // 
            // DtpCıkısTarih
            // 
            DtpCıkısTarih.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            DtpCıkısTarih.Location = new Point(529, 143);
            DtpCıkısTarih.Name = "DtpCıkısTarih";
            DtpCıkısTarih.Size = new Size(251, 28);
            DtpCıkısTarih.TabIndex = 42;
            // 
            // DtpGiristarih
            // 
            DtpGiristarih.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            DtpGiristarih.Location = new Point(529, 103);
            DtpGiristarih.Name = "DtpGiristarih";
            DtpGiristarih.Size = new Size(251, 28);
            DtpGiristarih.TabIndex = 41;
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.Enabled = false;
            TxtOdaNo.Location = new Point(529, 18);
            TxtOdaNo.Multiline = true;
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(251, 31);
            TxtOdaNo.TabIndex = 40;
            // 
            // TxtUcret
            // 
            TxtUcret.Location = new Point(529, 57);
            TxtUcret.Multiline = true;
            TxtUcret.Name = "TxtUcret";
            TxtUcret.Size = new Size(251, 31);
            TxtUcret.TabIndex = 39;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(137, 13);
            TxtAd.Multiline = true;
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(251, 31);
            TxtAd.TabIndex = 38;
            // 
            // TxtKimlikNo
            // 
            TxtKimlikNo.Location = new Point(137, 232);
            TxtKimlikNo.MaxLength = 11;
            TxtKimlikNo.Multiline = true;
            TxtKimlikNo.Name = "TxtKimlikNo";
            TxtKimlikNo.Size = new Size(251, 31);
            TxtKimlikNo.TabIndex = 37;
            // 
            // TxtMail
            // 
            TxtMail.Location = new Point(137, 188);
            TxtMail.Multiline = true;
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(251, 31);
            TxtMail.TabIndex = 36;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(137, 57);
            TxtSoyad.Multiline = true;
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(251, 31);
            TxtSoyad.TabIndex = 35;
            // 
            // MskTxtTelefon
            // 
            MskTxtTelefon.Location = new Point(137, 145);
            MskTxtTelefon.Mask = "(999) 000-0000";
            MskTxtTelefon.Name = "MskTxtTelefon";
            MskTxtTelefon.Size = new Size(251, 27);
            MskTxtTelefon.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(801, 110);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 33;
            label11.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label10.Location = new Point(432, 145);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 32;
            label10.Text = "Çıkış Tarihi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(433, 103);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 31;
            label9.Text = "Giriş Tarihi:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(466, 59);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 30;
            label8.Text = "Ücret:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(406, 18);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 29;
            label7.Text = "Oda Numarası:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(18, 235);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 28;
            label6.Text = "TC Kimlik No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(75, 191);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 27;
            label5.Text = "Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(48, 147);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 26;
            label4.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(43, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 25;
            label3.Text = "Cinsiyet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(58, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 24;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(84, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 23;
            label1.Text = "Ad:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(771, 224);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 31);
            textBox1.TabIndex = 45;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(713, 235);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(31, 20);
            label12.TabIndex = 46;
            label12.Text = "Ad:";
            // 
            // BtnTemizle
            // 
            BtnTemizle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            BtnTemizle.Location = new Point(898, 136);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(124, 29);
            BtnTemizle.TabIndex = 47;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.UseVisualStyleBackColor = true;
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // Musteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1024, 486);
            Controls.Add(BtnTemizle);
            Controls.Add(label12);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(CmbCinsiyet);
            Controls.Add(DtpCıkısTarih);
            Controls.Add(DtpGiristarih);
            Controls.Add(TxtOdaNo);
            Controls.Add(TxtUcret);
            Controls.Add(TxtAd);
            Controls.Add(TxtKimlikNo);
            Controls.Add(TxtMail);
            Controls.Add(TxtSoyad);
            Controls.Add(MskTxtTelefon);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnAra);
            Controls.Add(BtnSil);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnVerileriGoster);
            Controls.Add(listView1);
            MinimizeBox = false;
            Name = "Musteriler";
            Text = "Müşteri Bilgileri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button BtnVerileriGoster;
        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnAra;
        private Button button4;
        private ComboBox CmbCinsiyet;
        private DateTimePicker DtpCıkısTarih;
        private DateTimePicker DtpGiristarih;
        private TextBox TxtOdaNo;
        private TextBox TxtUcret;
        private TextBox TxtAd;
        private TextBox TxtKimlikNo;
        private TextBox TxtMail;
        private TextBox TxtSoyad;
        private MaskedTextBox MskTxtTelefon;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label12;
        private Button BtnTemizle;
    }
}