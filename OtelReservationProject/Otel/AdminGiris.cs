using System;
using System.Data.SQLite; // SQLite işlemleri için
using System.IO; // Dosya işlemleri için
using System.Windows.Forms;

namespace Otel
{
    public partial class AdminGiris : Form
    {
        private readonly string connectionString = @"Data Source=C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db;Version=3;";

        public AdminGiris()
        {
            InitializeComponent();
        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {
            try
            {
                // Eğer veritabanı dosyası yoksa oluştur
                if (!File.Exists(@"C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db"))
                {
                    SQLiteConnection.CreateFile(@"C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db");
                    MessageBox.Show("Veritabanı dosyası oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı tablosunu oluştur
                    string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Kullanici (
                        KullaniciAdi TEXT NOT NULL UNIQUE,
                        Sifre TEXT NOT NULL
                    )";

                    using (var command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata meydana geldi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGrs_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox5.Text.Trim();
            string sifre = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı adı ve şifre kontrolü
                    string query = "SELECT COUNT(*) FROM Kullanici WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@sifre", sifre);

                        int userExists = Convert.ToInt32(command.ExecuteScalar());
                        if (userExists > 0)
                        {
                            MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Ana sayfaya yönlendirme
                            AnaSayfa fr = new AnaSayfa();
                            fr.Show();
                            this.Hide(); // Mevcut formu gizle
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata meydana geldi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*'; // Şifreyi '*' ile gizler
        }
    }
}
