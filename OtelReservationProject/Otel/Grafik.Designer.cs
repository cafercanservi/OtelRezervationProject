namespace Otel
{
    partial class Grafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            genderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)genderChart).BeginInit();
            SuspendLayout();
            // 
            // genderChart
            // 
            chartArea1.Name = "ChartArea1";
            genderChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            genderChart.Legends.Add(legend1);
            genderChart.Location = new Point(102, 38);
            genderChart.Name = "genderChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            genderChart.Series.Add(series1);
            genderChart.Size = new Size(537, 373);
            genderChart.TabIndex = 0;
            genderChart.Text = "chart1";
            genderChart.Click += genderChart_Click;
            // 
            // Grafik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(genderChart);
            Name = "Grafik";
            Text = "Grafik";
            Load += Grafik_Load;
            ((System.ComponentModel.ISupportInitialize)genderChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart genderChart;
    }
}