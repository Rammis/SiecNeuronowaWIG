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
using System;
using System.IO;
using System.Windows.Forms;

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
            string file="";
            Dictionary<string, int> ExceptionMessages = new Dictionary<string, int>();
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = openFileDialog1.FileName;
              
            }

            string[] lines = File.ReadAllLines(file);

            for (int i = 0; i <lines.Count(); i+=2)
            {
                ExceptionMessages.Add(lines[i + 1], int.Parse(lines[i]));
            }

           
            chart1.Series.Add("WIG20");
            foreach (KeyValuePair<string, int> exception in ExceptionMessages)
                chart1.Series["WIG20"].Points.AddXY(exception.Key, exception.Value);

            chart1.Series["WIG20"].ChartType = SeriesChartType.Line;
        }

        private void nauka_Click(object sender, EventArgs e)
        {

        }

        private void prognozuj_Click(object sender, EventArgs e)
        {

        }

        
    }
}
