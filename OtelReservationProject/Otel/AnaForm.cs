using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGiris fr = new AdminGiris();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YeniMusteri fr = new YeniMusteri();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar fr = new Odalar();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Musteriler fr = new Musteriler();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Grafik fr =new Grafik();
            fr.Show();
        }
    }
}
