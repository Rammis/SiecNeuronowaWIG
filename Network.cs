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
        int wynikOczekiwany;
        int ilosc_danych;
        int ilosc_nauk;
        const double wzrost = 0.99999;
        const double spadek = -0.99999;
        const double bezZmian = 0;
        const double parametrN = 0.8;
        double wynik;
        String adresPliku;
        String nazwaSieci;        
        bool creating;


        public Network(List<Double> _values, bool _creating, int _wynikOczekiwany, int _ilosc_pierwsza, int _ilosc_druga, int _ilosc_danych, String _adresPliku, int _ilosc_nauk)
        {
            values = _values;
            creating = _creating;
            wynikOczekiwany = _wynikOczekiwany;
            ilosc_pierwsza = _ilosc_pierwsza;
            ilosc_druga = _ilosc_druga;
            ilosc_danych = _ilosc_danych;
            ilosc_nauk = _ilosc_nauk;
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

            for (int i = 0; i < ilosc_druga; i++)
            {
                druga[i].setValues(pierwszaWarstwa); //wyniki pierwszej warsty do drugiej
                drugaWarstwa.Add(druga[i].getWyjscie());

            }
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
            
            wagi_wynikowy = wynikowy.getWeights();
            for (int i = 0; i < ilosc_druga; i++)
                wagi_druga.Add(druga[i].getWeights());
            for (int i = 0; i < ilosc_pierwsza; i++)
                wagi_pierwsza.Add(pierwsza[i].getWeights());

            
            if (wynikOczekiwany == 1) //obliczamy deltę
                deltaOgolna = wzrost - wynik;
            else if (wynikOczekiwany == -1)
                deltaOgolna = spadek - wynik;
            else
                deltaOgolna = bezZmian - wynik;

            
            for (int i = 0; i < wagi_wynikowy.Count; i++)
                delty_druga.Add(wagi_wynikowy[i] * deltaOgolna);
            
            for (int i = 0; i < ilosc_pierwsza; i++)
            {
                double tmp_delta = 0;

                for (int j = 0; j < ilosc_druga; j++)
                    tmp_delta += wagi_druga[j][i] * delty_druga[j];

                delty_pierwsza.Add(tmp_delta);

            }


            for (int i = 0; i < ilosc_pierwsza; i++)
            {
                for (int j = 0; j < ilosc_druga; j++)
                    wagi_druga[j][i] = wagi_druga[j][i] + parametrN * delty_druga[j] * (1 - Math.Pow(Math.Tanh(druga[j].getWynik()), 2.0));
            }

            for (int i = 0; i < ilosc_danych; i++)
            {
                for (int j = 0; j < ilosc_pierwsza; j++)
                    wagi_pierwsza[j][i] = wagi_pierwsza[j][i] + parametrN * delty_pierwsza[j] * (1 - Math.Pow(Math.Tanh(pierwsza[j].getWynik()), 2.0));
            }
            
            for (int i = 0; i < wagi_wynikowy.Count; i++)
                wagi_wynikowy[i] = wagi_wynikowy[i] + parametrN * deltaOgolna * (1 - Math.Pow(Math.Tanh(wynikowy.getWynik()), 2.0));


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
                    for (int j = 0; j < ilosc_danych; j++)
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
                    for (int j = 0; j < ilosc_pierwsza; j++)
                    {
                        tmp.Add(double.Parse(lines[wskaznik]));
                        wskaznik++;
                    }
                    wagi_druga.Add(tmp);
                }

                for (int j = 0; j < lines.Count(); j++)
                {
                    if (lines[j] == "pierwsza")
                    {
                        wskaznik = j + 1;
                        break;
                    }
                }

                for (int i = 0; i < ilosc_druga; i++)
                {
                    wagi_wynikowy.Add(double.Parse(lines[wskaznik]));
                    wskaznik++;
                }

                for (int i = 0; i < ilosc_pierwsza; i++)
                {

                    pierwsza.Add(new Neuron(i, ilosc_danych, (int)TypesofNeuron.wejsciowy, wagi_pierwsza[i]));
                    pierwsza[i].setValues(values);
                    
                }

                for (int i = 0; i < ilosc_druga; i++)
                {
                    druga.Add(new Neuron(i, ilosc_pierwsza, (int)TypesofNeuron.srodkowy, wagi_druga[i]));
                }

                wynikowy = new Neuron(0, ilosc_druga, (int)TypesofNeuron.wynikowy, wagi_wynikowy);
            }
            else
            {
                for (int i = 0; i < ilosc_pierwsza; i++)
                {
                    pierwsza.Add(new Neuron(i, ilosc_danych, (int)TypesofNeuron.wejsciowy, null));
                    pierwsza[i].setValues(values);
                }

                for (int i = 0; i < ilosc_druga; i++)
                {
                    druga.Add(new Neuron(i, ilosc_pierwsza, (int)TypesofNeuron.srodkowy, null));
                }

                wynikowy = new Neuron(0, ilosc_druga, (int)TypesofNeuron.wynikowy, null);
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
                    for (int j = 0; j < ilosc_danych; j++)
                        file.WriteLine(wagi_pierwsza[i][j]);
                }
                file.WriteLine("druga");

                for (int i = 0; i < wagi_druga.Count; i++)
                {
                    for (int j = 0; j < wagi_pierwsza.Count; j++)
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
