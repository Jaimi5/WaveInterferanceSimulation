﻿namespace WaveSimulatorV2 {
    partial class WaveInterferanceSimulator {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.lambdatext = new System.Windows.Forms.Label();
            this.dist = new System.Windows.Forms.Label();
            this.WavelenghtValue = new System.Windows.Forms.TextBox();
            this.DistanceSlits = new System.Windows.Forms.TextBox();
            this.NumberOfSlitstext = new System.Windows.Forms.Label();
            this.SlitsWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SlitsNumber = new System.Windows.Forms.NumericUpDown();
            this.LightNumber = new System.Windows.Forms.NumericUpDown();
            this.LightNumberText = new System.Windows.Forms.Label();
            this.Distance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearChart = new System.Windows.Forms.Button();
            this.Amplitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DistanceOftheScreen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlitsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceOftheScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1748, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "GenerateChart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lambdatext
            // 
            this.lambdatext.AutoSize = true;
            this.lambdatext.Location = new System.Drawing.Point(1788, 254);
            this.lambdatext.Name = "lambdatext";
            this.lambdatext.Size = new System.Drawing.Size(65, 13);
            this.lambdatext.TabIndex = 1;
            this.lambdatext.Text = "Wavelenght";
            // 
            // dist
            // 
            this.dist.AutoSize = true;
            this.dist.Location = new System.Drawing.Point(1757, 147);
            this.dist.Name = "dist";
            this.dist.Size = new System.Drawing.Size(113, 13);
            this.dist.TabIndex = 2;
            this.dist.Text = "Distance between slits";
            // 
            // WavelenghtValue
            // 
            this.WavelenghtValue.Location = new System.Drawing.Point(1760, 270);
            this.WavelenghtValue.Name = "WavelenghtValue";
            this.WavelenghtValue.Size = new System.Drawing.Size(110, 20);
            this.WavelenghtValue.TabIndex = 5;
            // 
            // DistanceSlits
            // 
            this.DistanceSlits.Location = new System.Drawing.Point(1760, 163);
            this.DistanceSlits.Name = "DistanceSlits";
            this.DistanceSlits.Size = new System.Drawing.Size(110, 20);
            this.DistanceSlits.TabIndex = 3;
            // 
            // NumberOfSlitstext
            // 
            this.NumberOfSlitstext.AutoSize = true;
            this.NumberOfSlitstext.Location = new System.Drawing.Point(1757, 206);
            this.NumberOfSlitstext.Name = "NumberOfSlitstext";
            this.NumberOfSlitstext.Size = new System.Drawing.Size(78, 13);
            this.NumberOfSlitstext.TabIndex = 5;
            this.NumberOfSlitstext.Text = "Number of Slits";
            // 
            // SlitsWidth
            // 
            this.SlitsWidth.Location = new System.Drawing.Point(1760, 102);
            this.SlitsWidth.Name = "SlitsWidth";
            this.SlitsWidth.Size = new System.Drawing.Size(110, 20);
            this.SlitsWidth.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1757, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Slits Width";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1686, 999);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // SlitsNumber
            // 
            this.SlitsNumber.Location = new System.Drawing.Point(1760, 222);
            this.SlitsNumber.Name = "SlitsNumber";
            this.SlitsNumber.Size = new System.Drawing.Size(110, 20);
            this.SlitsNumber.TabIndex = 4;
            this.SlitsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LightNumber
            // 
            this.LightNumber.Location = new System.Drawing.Point(1760, 324);
            this.LightNumber.Name = "LightNumber";
            this.LightNumber.Size = new System.Drawing.Size(110, 20);
            this.LightNumber.TabIndex = 6;
            this.LightNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LightNumberText
            // 
            this.LightNumberText.AutoSize = true;
            this.LightNumberText.Location = new System.Drawing.Point(1757, 308);
            this.LightNumberText.Name = "LightNumberText";
            this.LightNumberText.Size = new System.Drawing.Size(87, 13);
            this.LightNumberText.TabIndex = 11;
            this.LightNumberText.Text = "Number of Lights";
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(1760, 376);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(110, 20);
            this.Distance.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1757, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Distance to the Screen";
            // 
            // ClearChart
            // 
            this.ClearChart.Location = new System.Drawing.Point(1748, 555);
            this.ClearChart.Name = "ClearChart";
            this.ClearChart.Size = new System.Drawing.Size(135, 56);
            this.ClearChart.TabIndex = 10;
            this.ClearChart.Text = "ClearChart";
            this.ClearChart.UseVisualStyleBackColor = true;
            this.ClearChart.Click += new System.EventHandler(this.ClearChart_Click);
            // 
            // Amplitude
            // 
            this.Amplitude.Location = new System.Drawing.Point(1760, 48);
            this.Amplitude.Name = "Amplitude";
            this.Amplitude.Size = new System.Drawing.Size(110, 20);
            this.Amplitude.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1757, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amplitude";
            // 
            // DistanceOftheScreen
            // 
            this.DistanceOftheScreen.Location = new System.Drawing.Point(1760, 422);
            this.DistanceOftheScreen.Name = "DistanceOftheScreen";
            this.DistanceOftheScreen.Size = new System.Drawing.Size(110, 20);
            this.DistanceOftheScreen.TabIndex = 8;
            this.DistanceOftheScreen.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1757, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Distance of the Screen";
            // 
            // WaveInterferanceSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DistanceOftheScreen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amplitude);
            this.Controls.Add(this.ClearChart);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LightNumber);
            this.Controls.Add(this.LightNumberText);
            this.Controls.Add(this.SlitsNumber);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.SlitsWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfSlitstext);
            this.Controls.Add(this.DistanceSlits);
            this.Controls.Add(this.WavelenghtValue);
            this.Controls.Add(this.dist);
            this.Controls.Add(this.lambdatext);
            this.Controls.Add(this.button1);
            this.Name = "WaveInterferanceSimulator";
            this.Text = "Wave Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlitsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceOftheScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Amplitude;
        private System.Windows.Forms.TextBox SlitsWidth;
        private System.Windows.Forms.TextBox DistanceSlits;
        private System.Windows.Forms.NumericUpDown SlitsNumber;
        private System.Windows.Forms.TextBox WavelenghtValue;
        private System.Windows.Forms.NumericUpDown LightNumber;
        private System.Windows.Forms.TextBox Distance;
        private System.Windows.Forms.NumericUpDown DistanceOftheScreen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label NumberOfSlitstext;
        private System.Windows.Forms.Label LightNumberText;
        private System.Windows.Forms.Label dist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lambdatext;
        private System.Windows.Forms.Label label4;
    }
}

