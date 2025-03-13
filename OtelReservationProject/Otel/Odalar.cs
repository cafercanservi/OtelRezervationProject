using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Otel
{
    public partial class Odalar : Form
    {
        // SQLite bağlantısını form seviyesinde tanımlıyoruz
        private SQLiteConnection baglanti;

        public Odalar()
        {
            InitializeComponent();
            // SQLite bağlantısını oluştur
            baglanti = new SQLiteConnection(@"Data Source=C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db;Version=3;");
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            baglanti.Open(); // Veritabanı bağlantısını aç
            OdaBilgileriniYukle(); // Odaların bilgilerini yükle
            baglanti.Close(); // Bağlantıyı kapat
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
                }
                // Eğer kayıt yoksa hiçbir işlem yapılmaz
            }
        }
    }
}


