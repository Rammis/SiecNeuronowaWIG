namespace SiecNeuronowa
{
    partial class WigGui
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.wczytajDane = new System.Windows.Forms.Button();
            this.nauka = new System.Windows.Forms.Button();
            this.prognozuj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(448, 416);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // wczytajDane
            // 
            this.wczytajDane.Location = new System.Drawing.Point(490, 38);
            this.wczytajDane.Name = "wczytajDane";
            this.wczytajDane.Size = new System.Drawing.Size(145, 38);
            this.wczytajDane.TabIndex = 1;
            this.wczytajDane.Text = "Wczytaj dane";
            this.wczytajDane.UseVisualStyleBackColor = true;
            this.wczytajDane.Click += new System.EventHandler(this.wczytajDane_Click);
            // 
            // nauka
            // 
            this.nauka.Location = new System.Drawing.Point(490, 82);
            this.nauka.Name = "nauka";
            this.nauka.Size = new System.Drawing.Size(145, 38);
            this.nauka.TabIndex = 2;
            this.nauka.Text = "Nauka";
            this.nauka.UseVisualStyleBackColor = true;
            this.nauka.Click += new System.EventHandler(this.nauka_Click);
            // 
            // prognozuj
            // 
            this.prognozuj.Location = new System.Drawing.Point(490, 126);
            this.prognozuj.Name = "prognozuj";
            this.prognozuj.Size = new System.Drawing.Size(145, 38);
            this.prognozuj.TabIndex = 3;
            this.prognozuj.Text = "Prognozuj";
            this.prognozuj.UseVisualStyleBackColor = true;
            this.prognozuj.Click += new System.EventHandler(this.prognozuj_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // WigGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 440);
            this.Controls.Add(this.prognozuj);
            this.Controls.Add(this.nauka);
            this.Controls.Add(this.wczytajDane);
            this.Controls.Add(this.chart1);
            this.Name = "WigGui";
            this.Text = "WigGui";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button wczytajDane;
        private System.Windows.Forms.Button nauka;
        private System.Windows.Forms.Button prognozuj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}