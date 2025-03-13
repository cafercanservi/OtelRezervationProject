using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Otel
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        SQLiteConnection baglantı = new SQLiteConnection(@"Data Source=C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db;Version=3;");

        private void verilergoster()
        {
            try
            {
                listView1.Items.Clear();
                using (var baglantı = new SQLiteConnection(@"Data Source=C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db;Version=3;"))
                {
                    baglantı.Open();

                    using (SQLiteCommand komut = new SQLiteCommand("SELECT * FROM Bilgiler", baglantı))
                    {
                        using (SQLiteDataReader oku = komut.ExecuteReader())
                        {
                            while (oku.Read())
                            {
                                ListViewItem ekle = new ListViewItem();
                                ekle.Text = oku["Id"].ToString();
                                ekle.SubItems.Add(oku["Ad"].ToString());
                                ekle.SubItems.Add(oku["Soyad"].ToString());
                                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                                ekle.SubItems.Add(oku["Telefon"].ToString());
                                ekle.SubItems.Add(oku["Mail"].ToString());
                                ekle.SubItems.Add(oku["TC"].ToString());
                                ekle.SubItems.Add(oku["OdaNo"].ToString());
                                ekle.SubItems.Add(oku["Ucret"].ToString());
                                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());

                                listView1.Items.Add(ekle);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        int id = 0;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                id = int.Parse(selectedItem.SubItems[0].Text);
                TxtAd.Text = selectedItem.SubItems[1].Text;
                TxtSoyad.Text = selectedItem.SubItems[2].Text;
                CmbCinsiyet.Text = selectedItem.SubItems[3].Text;
                MskTxtTelefon.Text = selectedItem.SubItems[4].Text;
                TxtMail.Text = selectedItem.SubItems[5].Text;
                TxtKimlikNo.Text = selectedItem.SubItems[6].Text;
                TxtOdaNo.Text = selectedItem.SubItems[7].Text;
                TxtUcret.Text = selectedItem.SubItems[8].Text;
                DtpGiristarih.Text = selectedItem.SubItems[9].Text;
                DtpCıkısTarih.Text = selectedItem.SubItems[10].Text;

                break;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (var baglantı = new SQLiteConnection(@"Data Source=C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db;Version=3;"))
                {
                    baglantı.Open();
                    using (var komut = new SQLiteCommand("DELETE FROM Bilgiler WHERE ID = @ID", baglantı))
                    {
                        komut.Parameters.AddWithValue("@ID", id);
                        komut.ExecuteNonQuery();
                    }
                }
                verilergoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtSoyad.Clear();
            CmbCinsiyet.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Clear();
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGiristarih.Text = "";
            DtpCıkısTarih.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var baglanti = new SQLiteConnection(@"Data Source=C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db;Version=3;"))
                {
                    baglanti.Open();

                    string sorgu = "UPDATE Bilgiler SET Ad = @Ad, Soyad = @Soyad, Cinsiyet = @Cinsiyet, Telefon = @Telefon, Mail = @Mail, TC = @TC, OdaNo = @OdaNo, Ucret = @Ucret, GirisTarihi = @GirisTarihi, CıkısTarihi = @CıkısTarihi WHERE ID = @ID";

                    using (var komut = new SQLiteCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@Ad", TxtAd.Text);
                        komut.Parameters.AddWithValue("@Soyad", TxtSoyad.Text);
                        komut.Parameters.AddWithValue("@Cinsiyet", CmbCinsiyet.Text);
                        komut.Parameters.AddWithValue("@Telefon", MskTxtTelefon.Text);
                        komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
                        komut.Parameters.AddWithValue("@TC", TxtKimlikNo.Text);
                        komut.Parameters.AddWithValue("@OdaNo", TxtOdaNo.Text);
                        komut.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
                        komut.Parameters.AddWithValue("@GirisTarihi", DtpGiristarih.Value);
                        komut.Parameters.AddWithValue("@CıkısTarihi", DtpCıkısTarih.Value);
                        komut.Parameters.AddWithValue("@ID", id);

                        komut.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Güncelleme başarılı!");
                verilergoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime girisTarihi = DtpGiristarih.Value;
                DateTime cikisTarihi = DtpCıkısTarih.Value;

                if (cikisTarihi <= girisTarihi)
                {
                    MessageBox.Show("Çıkış tarihi giriş tarihinden önce veya aynı gün olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label11.Text = "0 gün";
                    TxtUcret.Text = "0";
                    return;
                }
                TimeSpan fark = cikisTarihi - girisTarihi;
                int toplamGun = (int)Math.Ceiling(fark.TotalDays);

                label11.Text = $"{toplamGun} gün";

                int gunlukUcret = 50;
                int toplamUcret = toplamGun * gunlukUcret;
                TxtUcret.Text = toplamUcret.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tarih hesaplama hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label11.Text = "0 gün";
                TxtUcret.Text = "0";
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                using (var baglantı = new SQLiteConnection(@"Data Source=C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db;Version=3;"))
                {
                    baglantı.Open();

                    using (SQLiteCommand komut = new SQLiteCommand("SELECT * FROM Bilgiler where Ad like'%" + textBox1.Text + "%'", baglantı))
                    {
                        using (SQLiteDataReader oku = komut.ExecuteReader())
                        {
                            while (oku.Read())
                            {
                                ListViewItem ekle = new ListViewItem();
                                ekle.Text = oku["Id"].ToString();
                                ekle.SubItems.Add(oku["Ad"].ToString());
                                ekle.SubItems.Add(oku["Soyad"].ToString());
                                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                                ekle.SubItems.Add(oku["Telefon"].ToString());
                                ekle.SubItems.Add(oku["Mail"].ToString());
                                ekle.SubItems.Add(oku["TC"].ToString());
                                ekle.SubItems.Add(oku["OdaNo"].ToString());
                                ekle.SubItems.Add(oku["Ucret"].ToString());
                                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());

                                listView1.Items.Add(ekle);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}








