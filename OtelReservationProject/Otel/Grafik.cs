using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Otel
{
    public partial class Grafik : Form
    {
        private string dbPath = @"Data Source=C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db;Version=3;";

        public Grafik()
        {
            InitializeComponent();
        }

        private void Grafik_Load(object sender, EventArgs e)
        {
            DisplayGenderPieChart();
        }

        public void DisplayGenderPieChart()
        {
            int bayCount = 0;
            int bayanCount = 0;

            // Veritabanı bağlantısı ve verilerin alınması
            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\hp omen\source\repos\Otel\Otel\bin\Debug\OtelKayıt.db;Version=3;"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Cinsiyet, COUNT(*) AS Count FROM Bilgiler GROUP BY Cinsiyet";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string gender = reader["Cinsiyet"].ToString().ToLower();
                            int count = Convert.ToInt32(reader["Count"]);

                            if (gender == "bay")
                                bayCount = count;
                            else if (gender == "bayan")
                                bayanCount = count;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabanı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Eğer veri yoksa uyarı göster
            if (bayCount == 0 && bayanCount == 0)
            {
                MessageBox.Show("Grafik için yeterli veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Grafik yapılandırması
            genderChart.Series.Clear();

            Series series = new Series("Cinsiyet Dağılımı")
            {
                ChartType = SeriesChartType.Pie,
                BorderWidth = 2,
                Font = new Font("Arial", 10, FontStyle.Bold),
                IsValueShownAsLabel = true // Değerlerin dilim üzerinde gösterilmesi
            };

            genderChart.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea("ChartArea1")
            {
                Area3DStyle = { Enable3D = true, Inclination = 30 }
            };
            genderChart.ChartAreas.Add(chartArea);

            // Verilerin grafiğe eklenmesi
            series.Points.AddXY("Bay", bayCount);
            series.Points.AddXY("Bayan", bayanCount);

            genderChart.Series.Add(series);

            // Başlık ve stil ayarları
            genderChart.Titles.Clear();
            genderChart.Titles.Add("Cinsiyet Dağılımı");
            genderChart.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
        }

        private void genderChart_Click(object sender, EventArgs e)
        {
            // İsteğe bağlı olarak buraya bir işlem eklenebilir
        }
    }
}






