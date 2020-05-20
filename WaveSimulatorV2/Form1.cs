using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WaveSimulatorV2 {
    public partial class WaveInterferanceSimulator : Form {
        public WaveInterferanceSimulator() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            //chart.AxisX.Maximum = 100; If is need to put maximum
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 1;

            chart1.Series.Add("Interference");
            chart1.Series["Interference"].ChartType = SeriesChartType.FastLine; 
            chart1.Series["Interference"].Color = Color.Black;
            chart1.Series[0].IsVisibleInLegend = false;

            

            for(int i = 0; i<30000; i++)
                chart1.Series["Interference"].Points.AddXY(i, Math.Sin(i));
            double j = 30000;
            for (int i = 30000; i<60000; i++, j--)
                chart1.Series["Interference"].Points.AddXY(i,Math.Sin(j) ); 
        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
