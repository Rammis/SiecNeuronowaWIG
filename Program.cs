﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiecNeuronowa
{
    class Program
    {

       [STAThread]
        static void Main(string[] args){

            //int bwynik = readWynik();
            //List<double> liczby = readValues();

            //Network myNetwork = new Network(liczby, true, bwynik);
            //double wynik = myNetwork.getWynik();
            //myNetwork.learning();
            ///*for (int i = 0; i < liczby.Count; i++)
            //{
            //    Console.WriteLine(liczby[i]);
            //}*/



            //Console.WriteLine(wynik.ToString("F20",
            //      System.Globalization.CultureInfo.CreateSpecificCulture("es-ES")));
            //Console.WriteLine(bwynik.ToString());
            //Console.ReadKey();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WigGui());
            

        }


        private static List<double> readValues()
        {
            List<double> values = new List<double>();
            string[] lines = System.IO.File.ReadAllLines(@"Notowania\1.txt");


            for (int i = 0; i < lines.Length-1; i++)
                values.Add(double.Parse(lines[i]));
            
            
            return values;

        }
        private static int readWynik()
        {
            
            string[] lines = System.IO.File.ReadAllLines(@"Notowania\1.txt");
            if (lines[lines.Length - 1] == "true")
                return 1;
            else if (lines[lines.Length - 1] == "false")
                return -1;
            else
                return 0;

            
        }
    }

}
