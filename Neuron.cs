using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace SiecNeuronowa
{
    class Neuron
    {
        List<Double> wagi = new List<Double>();
        List<Double> wejscia = new List<Double>();
        int iloscWejsc;
        int numberOfNeuron;
        int type; // 0 - wejsciowy, 1 - srodkowy, 2 - koncowy
        double wyjscie;              
        double beta;

        public Neuron(int _numberOfNeuron, int _iloscWejsc, int _type, List<Double> _wagi, double _beta)
        {

            numberOfNeuron = _numberOfNeuron;
            iloscWejsc = _iloscWejsc;
            type = _type;
            wagi = _wagi;
            beta = _beta;

            if (_wagi == null)
            {
                wagi = new List<Double>();
                generateRandomWeights();
            }
            
        }


        public void setValues(List<Double> _wejscia)
        {
            wejscia.Clear();
            for (int i = 0; i < _wejscia.Count; i++)
            {
                wejscia.Add(_wejscia[i]);
            }
        }

        private void generateRandomWeights()
        {

            Random r = new Random();
            Thread.Sleep(30); //aby losowało różne liczby
            for (int i = 0; i < iloscWejsc; i++)
            {
                double tmp = r.NextDouble();
                wagi.Add(tmp);
            }


        }

        public List<Double> getWeights()
        {
            return wagi;
        }

        public List<Double> getValues()
        {
            return wejscia;
        }

        public void setWeights(List<double> _weights)
        {
            wagi = _weights;
        }

        public void loadWeightFromFile()
        {


        }

        public double getWyjscie()
        {

            double sumator = 0;

            for (int i = 0; i < wejscia.Count; i++)
            {

                sumator += wejscia[i] * wagi[i];

            }

            wyjscie = 1 / (1 + Math.Exp((-sumator)));
            

            return wyjscie;
        }

        public double getWynik()
        {
            return wyjscie;
        }

    }
}
