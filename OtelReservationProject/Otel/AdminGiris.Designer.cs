namespace Otel
{
    partial class AdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiris));
            textBox1 = new TextBox();
            BtnGrs = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            TxtSifre = new TextBox();
            TxtKullaniciAdi = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(76, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 44);
            textBox1.TabIndex = 0;
            textBox1.Text = "The Majestic Otele Hoşgeldiniz";
            // 
            // BtnGrs
            // 
            BtnGrs.BackColor = SystemColors.AppWorkspace;
            BtnGrs.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            BtnGrs.Location = new Point(256, 274);
            BtnGrs.Name = "BtnGrs";
            BtnGrs.Size = new Size(147, 44);
            BtnGrs.TabIndex = 3;
            BtnGrs.Text = "Giriş Yap";
            BtnGrs.UseVisualStyleBackColor = false;
            BtnGrs.Click += BtnGrs_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.InactiveCaption;
            textBox4.Location = new Point(256, 205);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(236, 35);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.InactiveCaption;
            textBox5.Location = new Point(256, 145);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(236, 34);
            textBox5.TabIndex = 5;
            // 
            // TxtSifre
            // 
            TxtSifre.BackColor = SystemColors.Info;
            TxtSifre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            TxtSifre.Location = new Point(147, 198);
            TxtSifre.Multiline = true;
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(71, 35);
            TxtSifre.TabIndex = 2;
            TxtSifre.Text = "Şifre:";
            // 
            // TxtKullaniciAdi
            // 
            TxtKullaniciAdi.BackColor = SystemColors.Info;
            TxtKullaniciAdi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            TxtKullaniciAdi.Location = new Point(76, 145);
            TxtKullaniciAdi.Multiline = true;
            TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            TxtKullaniciAdi.Size = new Size(142, 34);
            TxtKullaniciAdi.TabIndex = 1;
            TxtKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // AdminGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(861, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(BtnGrs);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullaniciAdi);
            Controls.Add(textBox1);
            Name = "AdminGiris";
            Text = "AdminGiris";
            Load += AdminGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button BtnGrs;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox TxtSifre;
        private TextBox TxtKullaniciAdi;
    }
}