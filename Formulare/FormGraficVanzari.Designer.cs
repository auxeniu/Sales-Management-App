namespace ProiectVanzari.Formulare
{
    partial class FormGraficVanzari
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartVanzari = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbTipGrafic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenereazaGrafic = new System.Windows.Forms.Button();
            this.panelTopControls = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartVanzari)).BeginInit();
            this.panelTopControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartVanzari
            // 
            this.chartVanzari.BorderlineColor = System.Drawing.Color.Gray;
            this.chartVanzari.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            chartArea1.Name = "ChartArea1";
            this.chartVanzari.ChartAreas.Add(chartArea1);
            this.chartVanzari.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartVanzari.Legends.Add(legend1);
            this.chartVanzari.Location = new System.Drawing.Point(10, 60);
            this.chartVanzari.Name = "chartVanzari";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DefaultSeries";
            this.chartVanzari.Series.Add(series1);
            this.chartVanzari.Size = new System.Drawing.Size(764, 391);
            this.chartVanzari.TabIndex = 0;
            this.chartVanzari.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Grafic Vânzări";
            this.chartVanzari.Titles.Add(title1);
            // 
            // cmbTipGrafic
            // 
            this.cmbTipGrafic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipGrafic.FormattingEnabled = true;
            this.cmbTipGrafic.Location = new System.Drawing.Point(87, 11);
            this.cmbTipGrafic.Name = "cmbTipGrafic";
            this.cmbTipGrafic.Size = new System.Drawing.Size(280, 21);
            this.cmbTipGrafic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tip de Grafic:";
            // 
            // btnGenereazaGrafic
            // 
            this.btnGenereazaGrafic.Location = new System.Drawing.Point(376, 9);
            this.btnGenereazaGrafic.Name = "btnGenereazaGrafic";
            this.btnGenereazaGrafic.Size = new System.Drawing.Size(120, 23);
            this.btnGenereazaGrafic.TabIndex = 3;
            this.btnGenereazaGrafic.Text = "Generează Grafic";
            this.btnGenereazaGrafic.UseVisualStyleBackColor = true;
            this.btnGenereazaGrafic.Click += new System.EventHandler(this.btnGenereazaGrafic_Click);
            // 
            // panelTopControls
            // 
            this.panelTopControls.Controls.Add(this.label1);
            this.panelTopControls.Controls.Add(this.btnGenereazaGrafic);
            this.panelTopControls.Controls.Add(this.cmbTipGrafic);
            this.panelTopControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopControls.Location = new System.Drawing.Point(10, 10);
            this.panelTopControls.Name = "panelTopControls";
            this.panelTopControls.Size = new System.Drawing.Size(764, 50);
            this.panelTopControls.TabIndex = 4;
            // 
            // FormGraficVanzari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.chartVanzari);
            this.Controls.Add(this.panelTopControls);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormGraficVanzari";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Grafice Vânzări";
            this.Load += new System.EventHandler(this.FormGraficVanzari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVanzari)).EndInit();
            this.panelTopControls.ResumeLayout(false);
            this.panelTopControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartVanzari;
        private System.Windows.Forms.ComboBox cmbTipGrafic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenereazaGrafic;
        private System.Windows.Forms.Panel panelTopControls;
    }
}