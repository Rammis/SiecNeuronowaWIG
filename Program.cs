using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiecNeuronowa
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"Wig.txt");
            List<double> liczby = new List<double>();


            Neuron neuron = new Neuron(5);
            
            for(int i =0; i< lines.Length; i++)
                liczby.Add(double.Parse(lines[i]));

            neuron.setValues(liczby);

            List<Double> _wagi = neuron.getWeights();
            List<Double> _wejscia = neuron.getValues();
            for (int i = 0; i < _wagi.Count; i++)
            {
                Console.Write(_wagi[i]);
                Console.Write("\n");
            }
            Console.WriteLine();

            for (int i = 0; i < _wejscia.Count; i++)
            {
                Console.Write(_wejscia[i]);
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
