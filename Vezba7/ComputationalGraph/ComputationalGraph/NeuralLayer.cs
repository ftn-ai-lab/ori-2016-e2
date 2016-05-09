using System.Collections.Generic;
using System.Linq;

namespace ComputationalGraph
{
    public class NeuralLayer
    {
        public int n_inputs;
        public int n_neurons;
        public string activation;
        public List<NeuronNode> neurons;

        public NeuralLayer(int n_inputs, int n_neurons, string activation)
        {
            this.n_inputs = n_inputs;
            this.n_neurons = n_neurons;
            this.activation = activation;
            this.neurons = new List<NeuronNode>();

            for (int i = 0; i < n_neurons; i++)
            {
                NeuronNode neuron = new NeuronNode(n_inputs, activation);
                this.neurons.Add(neuron);

            }
        }

        public List<double> forward(List<double> x)
        {
            List<double> layer_output = new List<double>();
            foreach (var neuron in this.neurons)
            {
                double neuron_output = neuron.forward(x);
                layer_output.Add(neuron_output);
            }

            return layer_output;
        }

        /// <summary>
        /// Propagacija backward signala kroz sve neurone u sloju
        /// </summary>
        /// <param name="dz">dz is a vector of "n_neurons" elements</param>
        /// <returns></returns>
        public List<List<double>> backward(List<List<double>> dz)
        {
            List<List<double>> backward_signal = new List<List<double>>();
            for (int i = 0; i < this.neurons.Count; i++)
            {
               List<double> neuron_dz = dz.Select(d => d[i]).ToList(); // selekcija i-te vrste u matrici
               neuron_dz = neurons[i].backward(neuron_dz);
               backward_signal.Add(neuron_dz.Take(neuron_dz.Count - 1).ToList());//sve osim poslednjeg zbog biasa
            }
            return backward_signal;
        }
        /// <summary>
        /// Koriguj tezine svih neurona
        /// </summary>
        /// <param name="learningRate"></param>
        /// <param name="momentum"></param>
        public void updateWeights(double learningRate, double momentum)
        {   //TODO 8: koriguj tezine svih neurona
            neurons.ForEach(neuron => neuron.updateWeights(learningRate, momentum));
        }
    }
}
