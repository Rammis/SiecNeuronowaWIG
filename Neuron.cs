using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiecNeuronowa
{
    class Neuron
    {
        List<Double> wagi = new List<Double>();
        List<Double> wejscia = new List<Double>();

        public Neuron(int iloscWejsc)
        {
            
            
            generateRandomWeights(iloscWejsc);

        }

        public void setValues(List<Double> _wejscia){

            for (int i = 0; i < _wejscia.Count; i++)
            {
                wejscia.Add(_wejscia[i]);
            }
        }

        private void generateRandomWeights(int iloscWejsc)
            {

                Random r = new Random();

                for (int i = 0; i < iloscWejsc; i++)
                {
                    double tmp = r.NextDouble() * (1 - 0.01) + 0.01;
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
    }
}
