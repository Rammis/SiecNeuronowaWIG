using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace SiecNeuronowa
{

    class Network
    {
        enum TypesofNeuron { wejsciowy = 0, srodkowy, wynikowy };
        List<Neuron> pierwsza = new List<Neuron>();
        List<Neuron> druga = new List<Neuron>();
        Neuron wynikowy;
        List<Double> values = new List<Double>(); //wartosci poczatkowe
        int ilosc_pierwsza;
        int ilosc_druga;
        double wynikOczekiwany;
        int ilosc_danych;
        int ilosc_nauk;

        int ilosc_wejsc_druga;
        int ilosc_wejsc_pierwsza;
        int ilosc_wejsc_trzecia;
        const double wzrost = 0.99;
        const double spadek = 0.01;
        const double bezZmian = 0;
        double parametrN = 0.15;
        double wynik;
        String adresPliku;
        String nazwaSieci;        
        bool creating;


        public Network(List<Double> _values, bool _creating, double _wynikOczekiwany, int _ilosc_pierwsza, int _ilosc_druga, int _ilosc_danych, String _adresPliku, int _ilosc_nauk)
        {
            values = _values;

            creating = _creating;
            wynikOczekiwany = _wynikOczekiwany;
            ilosc_pierwsza = _ilosc_pierwsza;
            ilosc_druga = _ilosc_druga;
            ilosc_danych = _ilosc_danych;
            ilosc_nauk = _ilosc_nauk;
           
            
                

            ilosc_wejsc_pierwsza = _ilosc_danych;
            ilosc_wejsc_druga = ilosc_pierwsza + 1;
            ilosc_wejsc_trzecia = _ilosc_druga + 1;



            adresPliku = _adresPliku;
            nazwaSieci = _adresPliku.Remove(_adresPliku.Count() - 4);
            createNeurons();
            saveWeights();
        }
        public double getWynik()
        {
            List<Double> pierwszaWarstwa = new List<Double>();
            List<Double> drugaWarstwa = new List<Double>();

            for (int i = 0; i < ilosc_pierwsza; i++)
                pierwszaWarstwa.Add(pierwsza[i].getWyjscie()); //pobieram wyjscia pierwszego neurona
            pierwszaWarstwa.Add(1);
            for (int i = 0; i < ilosc_druga; i++)
            {
                druga[i].setValues(pierwszaWarstwa); //wyniki pierwszej warsty do drugiej
                drugaWarstwa.Add(druga[i].getWyjscie());

            }
            drugaWarstwa.Add(1);
            wynikowy.setValues(drugaWarstwa); //druga do trzeciej

            wynik = wynikowy.getWyjscie();
           
            return wynik;
        }
        public void learning()
        {

            double deltaOgolna;
            List<Double> delty_druga = new List<Double>();
            List<Double> delty_pierwsza = new List<Double>();

            List<Double> wagi_wynikowy = new List<Double>();
            List<List<Double>> wagi_druga = new List<List<Double>>();
            List<List<Double>> wagi_pierwsza = new List<List<Double>>();
            //wagi.Add(wynikowy.getWeights());

            List<Double> pierwszaWarstwa = new List<Double>();
            List<Double> drugaWarstwa = new List<Double>();

            for (int i = 0; i < ilosc_pierwsza; i++)
                pierwszaWarstwa.Add(pierwsza[i].getWyjscie()); //pobieram wyjscia pierwszego neurona
            pierwszaWarstwa.Add(1);
            for (int i = 0; i < ilosc_druga; i++)
            {
                druga[i].setValues(pierwszaWarstwa); //wyniki pierwszej warsty do drugiej
                drugaWarstwa.Add(druga[i].getWyjscie());

            }
            drugaWarstwa.Add(1);
            wynikowy.setValues(drugaWarstwa); //druga do trzeciej

            wagi_wynikowy = wynikowy.getWeights();
            for (int i = 0; i < ilosc_druga; i++)
                wagi_druga.Add(druga[i].getWeights());
            for (int i = 0; i < ilosc_pierwsza; i++)
                wagi_pierwsza.Add(pierwsza[i].getWeights());


            if (wynikOczekiwany == 0.99) //obliczamy deltę
                deltaOgolna = wzrost - wynik;
            else if (wynikOczekiwany == 0.01)
                deltaOgolna = wynik - spadek;
            else
                deltaOgolna = bezZmian - wynik;

            
            

            
            for (int i = 0; i < wagi_wynikowy.Count; i++)
                delty_druga.Add(wagi_wynikowy[i] * deltaOgolna);

            for (int i = 0; i < ilosc_wejsc_druga; i++)
            {
                double tmp_delta = 0;

                for (int j = 0; j < ilosc_druga; j++)
                    tmp_delta += wagi_druga[j][i] * delty_druga[j];

                delty_pierwsza.Add(tmp_delta);

            }

          



           

            for (int i = 0; i < ilosc_wejsc_druga; i++)
            {
                for (int j = 0; j < ilosc_druga; j++)
                {
                   

                   // wagi_druga[j][i] = wagi_druga[j][i] + parametrN * delty_druga[j] * (1 - Math.Pow(Math.Tanh(druga[j].getWynik()), 2.0)) * pierwszaWarstwa[i];

                    wagi_druga[j][i] = wagi_druga[j][i] + parametrN * delty_druga[j] * (1 / (1 + Math.Exp(-druga[j].getWynik()))) * (1 - (1 / (1 + Math.Exp(-druga[j].getWynik() * 0.000000000001)))) * pierwszaWarstwa[i];
                   
                   
                }
            }

            for (int i = 0; i < ilosc_wejsc_pierwsza; i++)
            {
                for (int j = 0; j < ilosc_pierwsza; j++)
                {
                 
                    //wagi_pierwsza[j][i] = wagi_pierwsza[j][i] + parametrN * delty_pierwsza[j] * (1 - Math.Pow(Math.Tanh(pierwsza[j].getWynik()), 2.0)) * values[i];
                    wagi_pierwsza[j][i] = wagi_pierwsza[j][i] + parametrN * delty_pierwsza[j] * (1 / (1 + Math.Exp(-pierwsza[j].getWynik()))) * (1 - (1 / (1 + Math.Exp(-pierwsza[j].getWynik() * 0.000000000001)))) * values[i];
                    if (double.IsNaN(wagi_pierwsza[j][i]))
                        wagi_pierwsza[j][i] = 0;
                }
            }

            for (int i = 0; i < wagi_wynikowy.Count; i++)
            {
               

               // wagi_wynikowy[i] = wagi_wynikowy[i] + parametrN * deltaOgolna * (1 - Math.Pow(Math.Tanh(wynikowy.getWynik()), 2.0)) * drugaWarstwa[i];
                wagi_wynikowy[i] = wagi_wynikowy[i] + parametrN * deltaOgolna * (1 / (1 + Math.Exp(-wynikowy.getWynik()))) * (1 - (1 / (1 + Math.Exp(-wynikowy.getWynik() * 0.000000000001)))) * drugaWarstwa[i];
                
                

            }


            wynikowy.setWeights(wagi_wynikowy);

            for (int i = 0; i < druga.Count; i++)
                druga[i].setWeights(wagi_druga[i]);

            for (int i = 0; i < druga.Count; i++)
                pierwsza[i].setWeights(wagi_pierwsza[i]);
        }

        public void createNeurons()
        {
            List<Double> wagi_wynikowy = new List<Double>();
            List<List<Double>> wagi_druga = new List<List<Double>>();
            List<List<Double>> wagi_pierwsza = new List<List<Double>>();
            int wskaznik = 0;
            string[] lines = File.ReadAllLines(adresPliku);
            // lines[0] - ilosc danych
            // lines[1] - ilosc pierwsza warstwa
            // lines[2] - ilosc druga warstwa
            // lines[3] - ilosc nauk
            // lines[4] - ""

            if (!creating)
            {

                for (int j = 0; j < lines.Count(); j++)
                {
                    if (lines[j] == "pierwsza")
                    {
                        wskaznik = j + 1;
                        break;
                    }
                }

                for (int i = 0; i < ilosc_pierwsza; i++)
                {
                    List<Double> tmp = new List<Double>();
                    for (int j = 0; j < ilosc_wejsc_pierwsza; j++)
                    {
                        tmp.Add(double.Parse(lines[wskaznik]));
                        wskaznik++;
                    }
                    wagi_pierwsza.Add(tmp);
                }

                for (int j = 0; j < lines.Count(); j++)
                {
                    if (lines[j] == "druga")
                    {
                        wskaznik = j + 1;
                        break;
                    }
                }

                for (int i = 0; i < ilosc_druga; i++)
                {
                    List<Double> tmp = new List<Double>();
                    for (int j = 0; j < ilosc_wejsc_druga; j++)
                    {
                        tmp.Add(double.Parse(lines[wskaznik]));
                        wskaznik++;
                    }
                    wagi_druga.Add(tmp);
                }

                for (int j = 0; j < lines.Count(); j++)
                {
                    if (lines[j] == "wynikowy")
                    {
                        wskaznik = j + 1;
                        break;
                    }
                }

                for (int i = 0; i < ilosc_wejsc_trzecia; i++)
                {
                    wagi_wynikowy.Add(double.Parse(lines[wskaznik]));
                    wskaznik++;
                }
                
                for (int i = 0; i < ilosc_pierwsza; i++)
                {

                    pierwsza.Add(new Neuron(i, ilosc_wejsc_pierwsza, (int)TypesofNeuron.wejsciowy, wagi_pierwsza[i],parametrN));
                    pierwsza[i].setValues(values);
                    
                }

                for (int i = 0; i < ilosc_druga; i++)
                {
                    druga.Add(new Neuron(i, ilosc_wejsc_druga, (int)TypesofNeuron.srodkowy, wagi_druga[i],parametrN));
                }

                wynikowy = new Neuron(0, ilosc_wejsc_trzecia, (int)TypesofNeuron.wynikowy, wagi_wynikowy,parametrN);
            }
            else
            {
                for (int i = 0; i < ilosc_pierwsza; i++)
                {
                    pierwsza.Add(new Neuron(i, ilosc_wejsc_pierwsza, (int)TypesofNeuron.wejsciowy, null,parametrN));
                    pierwsza[i].setValues(values);
                }

                for (int i = 0; i < ilosc_druga; i++)
                {
                    druga.Add(new Neuron(i, ilosc_wejsc_druga, (int)TypesofNeuron.srodkowy, null,parametrN));
                }

                wynikowy = new Neuron(0, ilosc_wejsc_trzecia, (int)TypesofNeuron.wynikowy, null,parametrN);
            }
        }

        public void saveWeights()
        {
            List<Double> wagi_wynikowy = new List<Double>();
            List<List<Double>> wagi_druga = new List<List<Double>>();
            List<List<Double>> wagi_pierwsza = new List<List<Double>>();

            wagi_wynikowy = wynikowy.getWeights();
            for (int i = 0; i < ilosc_druga; i++)
                wagi_druga.Add(druga[i].getWeights());
            for (int i = 0; i < ilosc_pierwsza; i++)
                wagi_pierwsza.Add(pierwsza[i].getWeights());

            using (System.IO.StreamWriter file =
              new System.IO.StreamWriter(@adresPliku, false))
            {
                file.WriteLine(ilosc_danych);
                file.WriteLine(ilosc_pierwsza);
                file.WriteLine(ilosc_druga);
                file.WriteLine(ilosc_nauk);
                file.WriteLine("pierwsza");

                for (int i = 0; i < wagi_pierwsza.Count; i++)
                {
                    for (int j = 0; j < ilosc_wejsc_pierwsza; j++)
                        file.WriteLine(wagi_pierwsza[i][j]);
                }
                file.WriteLine("druga");

                for (int i = 0; i < wagi_druga.Count; i++)
                {
                    for (int j = 0; j < ilosc_wejsc_druga; j++)
                        file.WriteLine(wagi_druga[i][j]);
                }
                file.WriteLine("wynikowy");

                for (int i = 0; i < wagi_wynikowy.Count; i++)
                {
                    file.WriteLine(wagi_wynikowy[i]);
                }
                
            }
        }
    }
}
