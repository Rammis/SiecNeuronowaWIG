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

using System.IO;


namespace SiecNeuronowa
{
    public partial class WigGui : Form
    {
        
        List<double> daneWejsciowe = new List<double>();
        int ilosc_danych;
        int ilosc_pierwsza_warstwa;
        int ilosc_druga_warstwa;
        int ilosc_nauk;
        int wynik_oczekiwany;
        String nazwa_pliku;
        String sciezka_pliku;
        bool czyNowa;      
        Network myNetwork;
        int zle=0;
        int dopsz = 0;
        double procent;

        public WigGui()
        {
            InitializeComponent();

          
            comboBox_ilosc_danych.SelectedIndex = 0;
            comboBox_pierwsza_warstwa.SelectedIndex = 0;
            comboBox_druga_warstwa.SelectedIndex = 0;
            openFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Filter = "Text|*.txt";

            this.BackColor = System.Drawing.Color.Gold;

            panel_konfiguracja.BackColor = System.Drawing.Color.LightCyan;
            panel_nowa_siec.BackColor = System.Drawing.Color.LightGreen;
            panel_wczytaj_siec.BackColor = System.Drawing.Color.LightGoldenrodYellow;

            tableLayoutPanel_dane.BackColor = System.Drawing.Color.Thistle;
            tableLayoutPanel_siec.BackColor = System.Drawing.Color.RoyalBlue;
            tableLayoutPanel_wyniki.BackColor = System.Drawing.Color.Chocolate;

            
            
        }

        private void wczytajDane_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            daneWejsciowe.Clear();

            label_wartosc_wynik_prognozowany.Text = "";
            label_wartosc_wynik_oczekiwany.Text = "";
            

            Dictionary<string, double> ExceptionMessages = new Dictionary<string, double>();
           
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String file_name;
                file_name = openFileDialog1.FileName;
                
                string[] lines = File.ReadAllLines(file_name);

                for (int i = 0; i < lines.Count()-1; i += 2)
                {
                    ExceptionMessages.Add(lines[i + 1], double.Parse(lines[i]));
                    daneWejsciowe.Add(double.Parse(lines[i]));
                }
                daneWejsciowe.Add(1);
                
                if (lines[lines.Count()-1] == "true")
                    wynik_oczekiwany = 1;
                else
                    wynik_oczekiwany = -1;

                chart1.Series.Add("WIG20");
                foreach (KeyValuePair<string, double> exception in ExceptionMessages)
                    chart1.Series["WIG20"].Points.AddXY(exception.Key, exception.Value);

                chart1.Series["WIG20"].ChartType = SeriesChartType.Line;
            }

            button_prognozuj.Enabled = true;
            

          
        }

        private void nauka_Click(object sender, EventArgs e)
        {
            //bool prawda = true;
            //while (prawda)
            //{
            //    double wynik = myNetwork.getWynik();
            //    if (wynik_oczekiwany == 1)
            //    {
            //        if (wynik >= 0.99)
            //        {
            //            prawda=false;
            //        }
            //    }
            //    else if (wynik_oczekiwany == -1)
            //    {
            //        if (wynik <= -0.99)
            //            prawda = false;
            //    }
                    myNetwork.learning();
                        myNetwork.saveWeights();
                        ilosc_nauk++;
            //}
         
            
            label_wartosc_ilosc_nauk.Text = ilosc_nauk.ToString();
            double oczekiwana = Double.Parse(label_wartosc_wynik_oczekiwany.Text);
            double prognozowana = Double.Parse(label_wartosc_wynik_prognozowany.Text);
            int znak_oczekiwana = Math.Sign(oczekiwana);
            int znak_prognozowana = Math.Sign(prognozowana);
            if (znak_oczekiwana == znak_prognozowana)
            {
                dopsz++;
            }
            else
            {
                zle++;
            }

            procent = (Convert.ToDouble(zle) / Convert.ToDouble(ilosc_nauk)) * 100;

            MessageBox.Show(string.Format("Nauka zakończona powodzeniem. Procent {0}",procent));

        }

        private void prognozuj_Click(object sender, EventArgs e)
        {
            myNetwork = new Network(daneWejsciowe, czyNowa, wynik_oczekiwany, ilosc_pierwsza_warstwa, ilosc_druga_warstwa, daneWejsciowe.Count, sciezka_pliku, ilosc_nauk);
            if (czyNowa)
                czyNowa = false;
            double wynik = myNetwork.getWynik();
            
            label_wartosc_wynik_prognozowany.Text = wynik.ToString();
            label_wartosc_wynik_oczekiwany.Text = wynik_oczekiwany.ToString();
            button_nauka.Enabled = true;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            czyNowa = true;
            ilosc_danych = int.Parse(comboBox_ilosc_danych.Text);
            ilosc_pierwsza_warstwa = int.Parse(comboBox_pierwsza_warstwa.Text);
            ilosc_druga_warstwa = int.Parse(comboBox_druga_warstwa.Text);
            ilosc_nauk = 0;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                sciezka_pliku = saveFileDialog1.FileName;
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine(ilosc_danych);
                    sw.WriteLine(ilosc_pierwsza_warstwa);
                    sw.WriteLine(ilosc_druga_warstwa);
                    sw.WriteLine(ilosc_nauk);
                    nazwa_pliku = System.IO.Path.GetFileName(saveFileDialog1.FileName);
                   
                }                             

                label_wartosc_ilosc_danych.Text = ilosc_danych.ToString();
                label_wartosc_pierwsza_warstwa.Text = ilosc_pierwsza_warstwa.ToString();
                label_wartosc_druga_warstwa.Text = ilosc_druga_warstwa.ToString();
                label_wartosc_ilosc_nauk.Text = ilosc_nauk.ToString();
                label_wartosc_nazwa_sieci.Text = nazwa_pliku;
                load_Components();

            }
            else
                MessageBox.Show("Nie podałeś nazwy pliku!");           
            
        }

        private void button_zakoncz_symulacje_Click(object sender, EventArgs e)
        {
            label_ilosc_danych.Visible = false;
            label_pierwsza_warstwa.Visible = false;
            label_druga_warstwa.Visible = false;
            label_ilosc_nauk.Visible = false;
            label_wartosc_ilosc_danych.Visible = false;
            label_wartosc_pierwsza_warstwa.Visible = false;
            label_wartosc_druga_warstwa.Visible = false;
            label_wartosc_ilosc_nauk.Visible = false;
            label_wynik_prognozowany.Visible = false;
            label_wartosc_wynik_prognozowany.Visible = false;
            label_wartosc_nazwa_sieci.Visible = false;
            label_nazwa_sieci.Visible = false;
            button_nauka.Visible = false;
            button_prognozuj.Visible = false;
            button_wczytaj_dane.Visible = false;
            button_zakoncz_symulacje.Visible = false;
            
            chart1.Visible = false;
            chart1.Series.Clear();
            tableLayoutPanel_dane.Visible = false;
            tableLayoutPanel_siec.Visible = false;
            tableLayoutPanel_wyniki.Visible = false;

            button_wczytaj_dane.Enabled = true;
            button_wczytaj_siec.Enabled = true;
            comboBox_ilosc_danych.Enabled = true;
            comboBox_pierwsza_warstwa.Enabled = true;
            comboBox_druga_warstwa.Enabled = true;
            button_zatwierdz_nowa_siec.Enabled = true;

            label_wartosc_wynik_prognozowany.Text = "";
            label_wartosc_wynik_oczekiwany.Text = "";

            daneWejsciowe.Clear();
            chart1.Series.Clear();

        }

        private void button_wczytaj_siec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String file_name;
                file_name = openFileDialog1.FileName;
                sciezka_pliku = openFileDialog1.FileName;
                nazwa_pliku = System.IO.Path.GetFileName(openFileDialog1.FileName);
                nazwa_pliku = nazwa_pliku.Remove(nazwa_pliku.Count() - 4);
                string[] lines = File.ReadAllLines(file_name);

                ilosc_danych = int.Parse(lines[0]);
                ilosc_pierwsza_warstwa = int.Parse(lines[1]);
                ilosc_druga_warstwa = int.Parse(lines[2]);
                ilosc_nauk = int.Parse(lines[3]);

                label_wartosc_ilosc_danych.Text = ilosc_danych.ToString();
                label_wartosc_pierwsza_warstwa.Text = ilosc_pierwsza_warstwa.ToString();
                label_wartosc_druga_warstwa.Text = ilosc_druga_warstwa.ToString();
                label_wartosc_ilosc_nauk.Text = ilosc_nauk.ToString();
                label_wartosc_nazwa_sieci.Text = nazwa_pliku;

                load_Components();
            }
            else
            {
                MessageBox.Show("Nie zaladowales pliku!");
            }
           
        }
    private void load_Components()
    {
        button_wczytaj_dane.Enabled = true;
        button_wczytaj_siec.Enabled = false;
        button_zakoncz_symulacje.Enabled = true;
        comboBox_ilosc_danych.Enabled = false;
        comboBox_pierwsza_warstwa.Enabled = false;
        comboBox_druga_warstwa.Enabled = false;
        button_zatwierdz_nowa_siec.Enabled = false;

        label_ilosc_danych.Visible = true;
        label_pierwsza_warstwa.Visible = true;
        label_druga_warstwa.Visible = true;
        label_ilosc_nauk.Visible = true;
        label_wartosc_ilosc_danych.Visible = true;
        label_wartosc_pierwsza_warstwa.Visible = true;
        label_wartosc_druga_warstwa.Visible = true;
        label_wartosc_ilosc_nauk.Visible = true;
        label_wynik_prognozowany.Visible = true;
        label_wartosc_wynik_prognozowany.Visible = true;
        label_nazwa_sieci.Visible = true;
        label_wartosc_nazwa_sieci.Visible = true;
        button_nauka.Visible = true;
        button_prognozuj.Visible = true;
        button_wczytaj_dane.Visible = true;
        button_zakoncz_symulacje.Visible = true;
        chart1.Visible = true;
        tableLayoutPanel_dane.Visible = true;
        tableLayoutPanel_siec.Visible = true;
        tableLayoutPanel_wyniki.Visible = true;

    }    
          
    }
}
