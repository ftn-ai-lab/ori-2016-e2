using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputationalGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            NeuralNetwork network = new NeuralNetwork();
            network.Add(new NeuralLayer(2, 2, "sigmoid"));
            network.Add(new NeuralLayer(2, 1, "sigmoid"));
           
            
            double[] x1 = { 0.0, 0.0 };
            double[] x2 = { 0.0, 1.0 };
            double[] x3 = { 1.0, 0.0 };
            double[] x4 = { 1.0, 1.0 };
            List<List<double>> X = new List<List<double>>() { x1.ToList(), x2.ToList(), x3.ToList(),x4.ToList()};

            double[] y1 = { 0.0 };
            double[] y2 = { 1.0 };
            double[] y3 = { 1.0 };
            double[] y4 = { 0.0 };
            List<List<double>> Y = new List<List<double>>() { y1.ToList(), y2.ToList(), y3.ToList(), y4.ToList() };

            network.fit(X, Y, 0.1, 0.9, 10000);
            Console.WriteLine(network.predict(x1.ToList())[0]);
            Console.WriteLine(network.predict(x2.ToList())[0]);
            Console.WriteLine(network.predict(x3.ToList())[0]);
            Console.WriteLine(network.predict(x4.ToList())[0]);
            Console.ReadLine();
        }
    }
}
