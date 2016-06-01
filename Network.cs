using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SiecNeuronowa
{
    
    class Network
    {
        List<Neuron> pierwsza = new List<Neuron>();
        List<Neuron> druga = new List<Neuron>();
        Neuron wynikowy;
        List<Double> values = new List<Double>(); //wartosci poczatkowe
        int wynikOczekiwany;
        const double wzrost = 0.99999;
        const double spadek = -0.99999;
        const double bezZmian = 0;
        const double parametrN = 0.8;
        double wynik;
        
       
        bool creating;

        public Network(List<Double> _values, bool _creating, int _wynikOczekiwany)
        {
            values = _values;
            creating = _creating;
            wynikOczekiwany = _wynikOczekiwany;

            for (int i = 0; i < 5; i++)
            {
                pierwsza.Add(new Neuron(creating, i, 5, 0));
                pierwsza[i].setValues(values);
            }

            for (int i = 0; i < 3; i++)
            {
                druga.Add(new Neuron(creating,i,5,1));
            }

            wynikowy = new Neuron(creating, 0, 3, 2);
            
        }

        public double getWynik(){
            List<Double> pierwszaWarstwa = new List<Double>();
            List<Double> drugaWarstwa = new List<Double>();

            for (int i = 0; i < 5; i++)
                pierwszaWarstwa.Add(pierwsza[i].getWyjscie());

            for (int i = 0; i < 3; i++)
            {
                druga[i].setValues(pierwszaWarstwa); //wyniki pierwszej warsty do drugiej
                drugaWarstwa.Add(druga[i].getWyjscie());

            }
            wynikowy.setValues(drugaWarstwa); //druga do trzeciej

            wynik = wynikowy.getWyjscie();



            return wynik;
        }
        public void learning(){
            
            double deltaOgolna;
            
            List<Double> wagi1 = new List<Double>();
            List<Double> wagi2 = new List<Double>();
            List<Double> wagi3 = new List<Double>();
            List<Double> wagi4 = new List<Double>();
            List<Double> wagi5 = new List<Double>();
            List<Double> wagi6 = new List<Double>();
            List<Double> wagi7 = new List<Double>();
            List<Double> wagi8 = new List<Double>();
            List<Double> wagi9 = new List<Double>();

            List<List<Double>> wagi = new List<List<Double>>();

            //wagi.Add(wynikowy.getWeights());

            //for (int i = 0; i < druga.Count; i++)
            //{
            //    wagi.Add(druga[i].getWeights());
            //}

            //for (int i = 0; i < pierwsza.Count; i++)
            //{
            //    wagi.Add(pierwsza[i].getWeights());
            //}

             wagi1 = wynikowy.getWeights();
            wagi2 = druga[0].getWeights();
            wagi3 = druga[1].getWeights();
            wagi4 = druga[2].getWeights();
            wagi5 = pierwsza[0].getWeights();
            wagi6 = pierwsza[1].getWeights();
            wagi7 = pierwsza[2].getWeights();
            wagi8 = pierwsza[3].getWeights();
            wagi9 = pierwsza[4].getWeights();



            List<Double> delty = new List<Double>();

            if (wynikOczekiwany == 1) //obliczamy deltę
                deltaOgolna = wzrost - wynik;
            else if (wynikOczekiwany == -1)
                deltaOgolna = spadek - wynik;
            else
                deltaOgolna = bezZmian - wynik;

            delty.Add(deltaOgolna);

            for (int i = 0; i < wagi1.Count; i++)
            {
                delty.Add(wagi1[i] * deltaOgolna);
            }


            for (int i = 0; i < 5; i++) { 
               // delty.Add(wagi2[0] * delty[1] + wagi3[0] * delty[2] + wagi4[0] * delty[3]);
                
                delty.Add(wagi2[i] * delty[1] + wagi3[i] * delty[2] + wagi4[i] * delty[3]);
                }


            for (int i = 0; i < 4; i++)
            {
            
            wagi2[i] = wagi2[i] + parametrN * delty[1] * (1 - Math.Pow(Math.Tanh(druga[0].getWynik()), 2));
            wagi3[i] = wagi3[i] + parametrN * delty[2] * (1 - Math.Pow(Math.Tanh(druga[1].getWynik()), 2));
            wagi4[i] = wagi4[i] + parametrN * delty[3] * (1 - Math.Pow(Math.Tanh(druga[2].getWynik()), 2));
            wagi5[i] = wagi5[i] + parametrN * delty[4] * (1 - Math.Pow(Math.Tanh(pierwsza[0].getWynik()), 2));
            wagi6[i] = wagi6[i] + parametrN * delty[5] * (1 - Math.Pow(Math.Tanh(pierwsza[1].getWynik()), 2));
            wagi7[i] = wagi7[i] + parametrN * delty[6] * (1 - Math.Pow(Math.Tanh(pierwsza[2].getWynik()), 2));
            wagi8[i] = wagi8[i] + parametrN * delty[7] * (1 - Math.Pow(Math.Tanh(pierwsza[3].getWynik()), 2));
            wagi9[i] = wagi9[i] + parametrN * delty[8] * (1 - Math.Pow(Math.Tanh(pierwsza[4].getWynik()), 2));
           
           }

            for (int i = 0; i < 3;i++ )
                wagi1[i] = wagi1[i] + parametrN * delty[0] * (1 - Math.Pow(Math.Tanh(pierwsza[0].getWynik()), 2));

            
            
            wynikowy.setWeights(wagi1);
            druga[0].setWeights(wagi2);
            druga[1].setWeights(wagi3);
            druga[2].setWeights(wagi4);
            pierwsza[0].setWeights(wagi5);
            pierwsza[1].setWeights(wagi6);
            pierwsza[2].setWeights(wagi7);
            pierwsza[3].setWeights(wagi8);
            pierwsza[4].setWeights(wagi9);
        
        
        
        
        
        }
    
    }
}
