using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Otel
{
    public partial class YeniMusteri : Form
    {
        private SQLiteConnection baglanti;
        public YeniMusteri()
        {
            InitializeComponent();
            baglanti = new SQLiteConnection(@"Data Source=C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db;Version=3;");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
        }

        private void BtnOda201_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "201";
        }

        private void BtnOda202_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "202";
        }

        private void BtnOda203_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "203";
        }

        private void BtnOda204_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "204";
        }

        private void BtnOda205_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "205";
        }

        private void BtnOda206_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "206";
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir.");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir.");
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = TxtAd.Text;
                string soyad = TxtSoyad.Text;
                string telefon = MskTxtTelefon.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                string mail = TxtMail.Text;
                string odaNo = TxtOdaNo.Text;
                string cinsiyet = CmbCinsiyet.Text;
                string kimlikNo = TxtKimlikNo.Text;
                string girisTarihi = DtpGiristarih.Value.ToString("yyyy-MM-dd");
                string cikisTarihi = DtpCıkısTarih.Value.ToString("yyyy-MM-dd");
                string ucret = TxtUcret.Text;

                if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(telefon) ||
                    string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(odaNo) || string.IsNullOrEmpty(cinsiyet) ||
                    string.IsNullOrEmpty(kimlikNo) || string.IsNullOrEmpty(ucret))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = @"Data Source=C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db;Version=3;";
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                    INSERT INTO Bilgiler (Ad, Soyad, Telefon, Mail, OdaNo, Cinsiyet, TC, GirisTarihi, CıkısTarihi, Ucret) 
                    VALUES (@ad, @soyad, @telefon, @mail, @odaNo, @cinsiyet, @kimlikNo, @girisTarihi, @cikisTarihi, @ucret)";

                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ad", ad);
                        command.Parameters.AddWithValue("@soyad", soyad);
                        command.Parameters.AddWithValue("@telefon", telefon);
                        command.Parameters.AddWithValue("@mail", mail);
                        command.Parameters.AddWithValue("@odaNo", odaNo);
                        command.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        command.Parameters.AddWithValue("@kimlikNo", kimlikNo);
                        command.Parameters.AddWithValue("@girisTarihi", girisTarihi);
                        command.Parameters.AddWithValue("@cikisTarihi", cikisTarihi);
                        command.Parameters.AddWithValue("@ucret", Convert.ToInt32(ucret));

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Müşteri başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"SQLite Hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri kaydedilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Giriş ve çıkış tarihlerini kontrol et
                DateTime girisTarihi = DtpGiristarih.Value;
                DateTime cikisTarihi = DtpCıkısTarih.Value;

                if (cikisTarihi <= girisTarihi)
                {
                    MessageBox.Show("Çıkış tarihi giriş tarihinden önce veya aynı gün olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label11.Text = "0 gün"; // Hata durumunda gün sayısını sıfırla
                    TxtUcret.Text = "0"; // Hata durumunda ücreti sıfırla
                    return;
                }

                // Tarihler arasındaki farkı hesapla
                TimeSpan fark = cikisTarihi - girisTarihi;
                int toplamGun = (int)Math.Ceiling(fark.TotalDays); // Gün sayısını al

                // Gün bilgisi label11'e yazdırılır
                label11.Text = $"{toplamGun} gün";

                // Ücret hesaplanır (günlük ücret: 50 TL)
                int gunlukUcret = 50;
                int toplamUcret = toplamGun * gunlukUcret;

                // Ücret bilgisi TxtUcret'e yazdırılır
                TxtUcret.Text = toplamUcret.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tarih hesaplama hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label11.Text = "0 gün"; // Hata durumunda gün sayısını sıfırla
                TxtUcret.Text = "0"; // Hata durumunda ücreti sıfırla
            }
        }

        private void YeniMusteri_Load(object sender, EventArgs e)
        {
            {
                baglanti.Open(); // Veritabanı bağlantısını aç
                OdaBilgileriniYukle(); // Odaların bilgilerini yükle
                baglanti.Close(); // Bağlantıyı kapat
            }
        }
        private void OdaBilgileriniYukle()
        {
            // Oda numaralarına göre bir döngü başlatıyoruz
            int[] odaNumaralari = { 101, 102, 103, 104, 105, 106, 201, 202, 203, 204, 205, 206 };

            foreach (int odaNo in odaNumaralari)
            {
                // Veritabanından kayıtlı bilgiyi al
                using var komut = new SQLiteCommand($"SELECT Ad, Soyad FROM Bilgiler WHERE OdaNo = '{odaNo}'", baglanti);
                using var okuyucu = komut.ExecuteReader();

                // Hangi butonun texti güncellenecekse belirliyoruz
                Button buton = this.Controls.Find($"BtnOda{odaNo}", true).FirstOrDefault() as Button;

                if (buton != null && okuyucu.Read()) // Eğer buton mevcut ve kayıt varsa
                {
                    buton.Text = $"{okuyucu["Ad"]} {okuyucu["Soyad"]}"; // Ad ve Soyad bilgisi butona yazılır
                    buton.BackColor = Color.Red;
                    buton.Enabled = false;
                }
                // Eğer kayıt yoksa hiçbir işlem yapılmaz
            }
        }
    }
}





