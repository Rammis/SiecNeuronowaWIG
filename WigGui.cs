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

namespace SiecNeuronowa
{
    public partial class WigGui : Form
    {
        public WigGui()
        {
            InitializeComponent();
        }

        private void wczytajDane_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            
            chart1.Series.Add("Wykres");
           
            for (int i = 0; i < 50; i++)
            {
                chart1.Series["Wykres"].Points.AddXY(r.Next(0, 10), r.Next(0, 10));
            }
            chart1.Series["Wykres"].ChartType = SeriesChartType.Line;
            chart1.Series["Wykres"].Color = Color.Coral;
        }

        private void nauka_Click(object sender, EventArgs e)
        {

        }

        private void prognozuj_Click(object sender, EventArgs e)
        {

        }

        
    }
}
