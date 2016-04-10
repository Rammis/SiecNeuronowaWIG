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
        bool creating;
        int numberOfNeuron;
        int type; // 0 - wejsciowy, 1 - srodkowy
        double wyjscie;

        const double beta = 0.5;

        public Neuron(bool _creating, int _numberOfNeuron, int _iloscWejsc, int _type)
        {
            creating = _creating;
            numberOfNeuron = _numberOfNeuron;
            iloscWejsc = _iloscWejsc;
            type = _type;

            if(creating)
            generateRandomWeights();
            else
            {
                getWeightsFromFile();
            }

        }

        public void setValues(List<Double> _wejscia){

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
                    double tmp = r.NextDouble() * (1 - (-1)) - 1;
                    wagi.Add(tmp);
                }

                setWeightsToFile();
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
            setWeightsToFile();
        }

        private void getWeightsFromFile()
        {
            string path = "Wagi\\" + type.ToString() + numberOfNeuron.ToString() + ".txt";
            string[] lines = System.IO.File.ReadAllLines(@path);


            for (int i = 0; i < lines.Length; i++)
                wagi.Add(double.Parse(lines[i]));

        }
        public void setWeightsToFile()
        {
          
            string path =  "Wagi\\" + type.ToString() + numberOfNeuron.ToString() + ".txt";

            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(@path))
            {

                for (int i = 0; i < wagi.Count; i++)
                    file.WriteLine(wagi[i].ToString());

            }
        }

        public double getWyjscie()
        {

            double sumator=0;
            
            for (int i = 0; i < wejscia.Count;i++) {

                sumator += wejscia[i] * wagi[i];

            }

            wyjscie = Math.Tanh(sumator);


                return wyjscie;
        }

        public double getWynik()
        {
            return wyjscie;
        }
    
    }
}
