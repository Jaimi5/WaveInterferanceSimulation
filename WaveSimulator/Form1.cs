using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WaveSimulator {
    public partial class WaveInterferanceSimulator : Form {

        public const double LIGHTSPEED = 2.9979e10;
        List<Color> Colors = new List<Color>();
        Random random = new Random();
        public WaveInterferanceSimulator() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            chart1.Series.Clear();
            InitializeColors();
        }

        private double Precision;

        private void button1_Click(object sender, EventArgs e) {
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].BackColor = Color.Beige;

            int numberofSlits = (int)SlitsNumber.Value;
            double wavelenght = double.Parse(WavelenghtValue.Text) * Math.Pow(10, -10); //Amstrongs
            double distancetoScreen = double.Parse(Distance.Text) * Math.Pow(10, -3); //milimeters
            double slitsWidth = double.Parse(SlitsWidth.Text) * Math.Pow(10, -3); //milimeters
            double amplitude = double.Parse(Amplitude.Text) * Math.Pow(10, -3); //milimeters
            double DistanceBetweenSlits = double.Parse(DistanceSlits.Text) * Math.Pow(10, -3); //milimeters
            int distanceOfScreen = (int)DistanceOftheScreen.Value;
            int numberOfLights = (int)LightNumber.Value;

            string ChartSerie = "Slits: " + numberofSlits + "\n Ligts: " + numberOfLights + "\n Wavelenght: " + wavelenght + "\n DistanceToScreen: " + distancetoScreen + "\n SlitsWidth: " + slitsWidth;

            if (!chart1.Series.Any(x => x.Name == ChartSerie)) {
                chart1.Series.Add(ChartSerie);
                chart1.Series[ChartSerie].ChartType = SeriesChartType.FastLine;
                chart1.Series[ChartSerie].Color = Colors[random.Next(0, Colors.Count() -1)];
                chart1.Series[ChartSerie].MarkerStep = 10;
            }

            Precision = Math.Pow(10, -6);
            List<double> vector = GetVectorSlits(numberofSlits, DistanceBetweenSlits);
            for (int i = -1000 * distanceOfScreen; i <= 1000 * distanceOfScreen; i++) {
                var aux = GetElectricFieldOfaPoint(i, distancetoScreen, amplitude, wavelenght, numberofSlits, vector, numberOfLights, slitsWidth);
                chart1.Series[ChartSerie].Points.AddXY((double)i / 1000, aux);
            }

        }

        private double GetDistance(int r, double distancetoScreen, double distanceToCenter) {
            return Math.Sqrt(Math.Pow(distanceToCenter - r * Precision, 2) + Math.Pow(distancetoScreen, 2));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        /// <param name="distancetoScreen"></param>
        /// <param name="amplitude"></param>
        /// <param name="wavelenght"></param>
        /// <param name="numberofSlits"></param>
        /// <param name="distanceVector"></param>
        /// <param name="numberOfLights"></param>
        /// <param name="slitsWidth"></param>
        /// <returns></returns>
        private double GetElectricFieldOfaPoint(int r, double distancetoScreen, double amplitude, double wavelenght, int numberofSlits, List<double> distanceVector, int numberOfLights, double slitsWidth) {
            double M = 10;
            double result = 0;
            List<double> distanceBetweenLights = GetVectorDistanceLights(numberOfLights, slitsWidth);
            for (int m = 0; m < 10; m++) {
                double mitjana = 0;
                for (int j = 0; j < numberofSlits; j++) {

                    for (int k = 0; k < distanceBetweenLights.Count(); k++) {
                        double distance = GetDistance(r, distancetoScreen, distanceVector[j] + distanceBetweenLights[k]);
                        mitjana += (amplitude / (distance + distanceBetweenLights[k])) * Math.Cos(2 * Math.PI * ((distance / wavelenght) - (m / M)));
                    }
                }
                result += Math.Pow(mitjana, 2);
            }

            return result / 10;

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

        private List<double> GetVectorDistanceLights(int numberOfLights, double slitsWidth) {
            List<double> slitslightPosition = new List<double>();
            double distanceBetweenSlits = slitsWidth / numberOfLights;
            for (int i = numberOfLights / 2 - 1; i >= 0; i--) {
                if (numberOfLights % 2 == 0)
                    slitslightPosition.Add(distanceBetweenSlits / 2 + distanceBetweenSlits * i);
                else
                    slitslightPosition.Add(distanceBetweenSlits * i + distanceBetweenSlits);
            }
            for (int i = 0; i < numberOfLights / 2; i++)
                slitslightPosition.Add(-slitslightPosition[i]);
            if (numberOfLights % 2 != 0)
                slitslightPosition.Add(0);

            return slitslightPosition;
        }

        private void ClearChart_Click(object sender, EventArgs e) {
            chart1.Series.Clear();
        }

        private void button2_Click(object sender, EventArgs e) {
            WavelenghtValue.Text = "5000";
            Distance.Text = "200";
            SlitsWidth.Text = "1";
            DistanceSlits.Text = "1";
            Amplitude.Text = "1000";
            SlitsNumber.Value = 1;
            LightNumber.Value = 1;
            DistanceOftheScreen.Value = 5;

            if (Ex1.Checked) {
                DistanceSlits.Text = "0,1";
                SlitsNumber.Value = 2;
            } else if (Ex2.Checked) {
                SlitsNumber.Value = 3;
                DistanceSlits.Text = "0,01";
                DistanceOftheScreen.Value = 15;
            } else if(Ex3.Checked) {
                SlitsWidth.Text = "0,02";
                LightNumber.Value = 20;
                DistanceOftheScreen.Value = 15;
            } else {
                SlitsWidth.Text = "0,02";
                LightNumber.Value = 20;
                DistanceSlits.Text = "0,1";
                DistanceOftheScreen.Value = 15;
            }
        }

        private void InitializeColors() {
            Colors = new List<Color>{ Color.Blue, Color.Red, Color.Green, Color.Black, Color.Orange};
        }
    }
}
