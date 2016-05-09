using System;
using System.Collections.Generic;

namespace ComputationalGraph
{
    public class NeuralNetwork
    {
        public List<NeuralLayer> layers { get; set; }

        public NeuralNetwork()
        {
            this.layers = new List<NeuralLayer>();
        }

        public void Add(NeuralLayer layer)
        {
            this.layers.Add(layer);
        }

        public List<double> forward(List<double> x)
        {
            List<double> prev_layer_output = new List<double>();

            for (int i = 0; i < this.layers.Count; i++)
            {
                if (i == 0)
                    prev_layer_output = layers[i].forward(x);
                else
                    prev_layer_output = layers[i].forward(prev_layer_output);
            }

            return prev_layer_output;
        }

        public List<List<double>> backward(List<List<double>> dz)
        {
            List<List<double>> next_layer_dz = new List<List<double>>();
            for (int i = layers.Count - 1; i >= 0; i--)
            {
                if (i == (layers.Count - 1))
                    next_layer_dz = layers[i].backward(dz);
                else
                    next_layer_dz = layers[i].backward(next_layer_dz);
            }

            return next_layer_dz;

        }

        public void updateWeights(double learningRate, double momentum)
        {
            layers.ForEach(layer => layer.updateWeights(learningRate, momentum));
        }

        public List<double> predict(List<double> x)
        {
            return this.forward(x);
        }

        public void fit(List<List<double>> X, List<List<double>> Y, double learningRate, double momentum, int nb_epochs)
        {
            double total_loss = 0.0;
            for (int n = 0; n < nb_epochs; n++)
            {
                for (int i = 0; i < X.Count; i++)
                {
                    List<double> x = X[i];
                    List<double> y = Y[i];
                    List<double> predicted = this.forward(x);
                    double grad = 0.0;

                    for (int j = 0; j < predicted.Count; j++)
                    {
                        double output = predicted[j];
                        double target = y[j];
                        //opadajuci gradijent
                        total_loss += Math.Pow((target - output), 2);
                        grad += -(target - output);
                    }
                    List<List<double>> gradient = new List<List<double>>() { new List<double>(){grad} };

                    this.backward(gradient);
                    this.updateWeights(learningRate, momentum);
                }
            }
        }
    }
}
