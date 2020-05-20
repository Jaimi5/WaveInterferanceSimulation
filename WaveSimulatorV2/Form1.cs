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

        private double Precision;

        private void button1_Click(object sender, EventArgs e) {
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            //chart.AxisX.Maximum = 100; If is need to put maximum
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = Math.Pow(10, -23);
            if (!chart1.Series.Any(x => x.Name == "Interference")) {
                chart1.Series.Add("Interference");
                chart1.Series["Interference"].ChartType = SeriesChartType.FastLine;
                chart1.Series["Interference"].Color = Color.Black;
                chart1.Series[0].IsVisibleInLegend = false;
            }

            int numberofSlits = (int)SlitsNumber.Value;
            double wavelenght = double.Parse(WavelenghtValue.Text) * Math.Pow(10, -10); //Amstrongs
            double amplitude = GetAmplitude(wavelenght);
            double distancetoScreen = double.Parse(Distance.Text) * Math.Pow(10, -3); //milimeters
            double slitsWidth = double.Parse(SlitsWidth.Text) * Math.Pow(10, -3); //milimeters

            Precision = wavelenght / 2;
            List<double> vector = GetVectorSlits(numberofSlits, slitsWidth);
            chart1.Series["Interference"].Points.Clear();
            for (int i = -60000; i<= 60000; i++)
                chart1.Series["Interference"].Points.AddXY(i, GetElectricFieldOfaPoint(i, distancetoScreen, amplitude, wavelenght, numberofSlits, vector));

        }



        private double GetDistance(int r, double distancetoScreen, double distanceToCenter) {
            return Math.Sqrt(Math.Pow(distanceToCenter - r * Precision, 2) + Math.Pow(distancetoScreen, 2));
        }

        private double GetElectricFieldOfaPoint(int r, double distancetoScreen, double amplitude, double wavelenght, int numberofSlits, List<double> distanceVector) {
            int M = 10;
            double result = 0;
            for (int j = 0; j < numberofSlits; j++) {
                double mitjana = 0;
                double distance = GetDistance(r, distancetoScreen, distanceVector[j]);
                for (int i = 1; i < M; i++)
                    mitjana += (amplitude / distance) * Math.Cos(2 * Math.PI * ((distance / wavelenght) - (i / M)));
                result += Math.Pow(mitjana/M, 2);
            }
            return result;
        }

        private double GetAmplitude(double waveLenght) {
            return waveLenght / (2 * Math.PI);
        }

        private List<double> GetVectorSlits(int numberSlits, double distanceSlits) {
            List<double> slitsPosition = new List<double>();

            for (int i = numberSlits / 2 - 1; i >= 0; i--) {
                if (numberSlits % 2 == 0)
                    slitsPosition.Add(distanceSlits / 2 + distanceSlits * i);
                else
                    slitsPosition.Add(distanceSlits * i + distanceSlits);
            }
            for (int i = 0; i < numberSlits / 2; i++)
                slitsPosition.Add(-slitsPosition[i]);

            if (numberSlits % 2 != 0)
                slitsPosition.Add(0);

            return slitsPosition;
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void chart1_Click(object sender, EventArgs e) {

        }
    }
}
