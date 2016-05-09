using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputationalGraph
{
    public class NeuronNode
    {
        public int n_inputs { get; set; }
        public List<MultiplyNode> multiplyNodes;
        public SumNode sumNode;
        public SigmoidNode activation_node;
        public List<double> previous_deltas;
        public List<List<double>> gradients;
        private Random rnd = new Random();

        /// <summary>
        /// https://en.wikipedia.org/wiki/Artificial_neuron
        /// ulaz1*tezina1
        /// ulaz1*tezina2
        /// bias(+1*tezina)
        /// sve se sabere
        /// provuce se kroz aktivacionu funkciju
        /// </summary>
        /// <param name="n_inputs"></param>
        /// <param name="activation"></param>
        public NeuronNode(int n_inputs, string activation)
        {
            this.n_inputs = n_inputs;
            this.multiplyNodes = new List<MultiplyNode>(); //for inputs and weights
            this.sumNode = new SumNode();                  //for sum of inputs*weights
            this.previous_deltas = new List<double>();     //vrednost delti u prosloj iteraciji
            this.gradients = new List<List<double>>();     //lokalni gradijenti
            MultiplyNode mulNode;
            
            //init inputs
            //collect inputs and corresponding weights
            for (int i = 0; i < this.n_inputs; i++)
            {
                mulNode = new MultiplyNode();
                mulNode.x = new List<double>() { 1.0, (rnd.NextDouble() - 0.5) / 50.0 };//izemdju -0.1 i 0.1
                this.multiplyNodes.Add(mulNode);
                previous_deltas.Add(0.0);
            }

            //init bias node and weight
            mulNode = new MultiplyNode();
            mulNode.x = new List<double>() { 1.0, (rnd.NextDouble() - 0.5 / 50.0) }; // -0.01 do 0.01
            this.multiplyNodes.Add(mulNode);
            previous_deltas.Add(0.0);

            if (activation.Equals("sigmoid"))
                this.activation_node = new SigmoidNode();
            else
                throw new NotImplementedException("Activation function is not supported");

        }
        /// <summary>
        /// Pomnoziti sve ulaze sa tezinama.
        /// Sabrati sve rezultate mnozaca. Kao povratnu vrednost
        /// vratiti vrednost aktivacione funkije za vrednost suma 
        /// svih mnozaca
        /// </summary>
        /// <param name="x">x is a vector of inputs</param>
        /// <returns></returns>
        public double forward(List<double> x)
        {
            List<double> inputs = new List<double>(x);
            inputs.Add(1.0); //bias

            List<double> forSum = new List<double>();
            //TODO 6: Izracunati vrednost na izlazu vestackog neurona
            for (int i = 0; i < inputs.Count; i++)
            {
                
            }

            double summed = 0.0;

            // dobijena vrednost se propusti kroz aktivacionu funkciju
            double summed_act = this.activation_node.forward(summed);
            return summed_act;
        }

        /// <summary>
        /// Greska se propagira u nazad kroz aktivacionu funkciju,
        /// preko sabiraca, do svakog pojedinacnog mnozaca
        /// </summary>
        /// <param name="dz"></param>
        /// <returns></returns>
        public List<double> backward(List<double> dz)
        {
            //greska svakog ulaza
            List<double> dw = new List<double>();
            double backward_signal = dz.Sum();

            //TODO 7: Izvrsiti propagaciju signala u nazad, prvo kroz aktivacionu funkciju,
            //        onda kroz sabirac pa kroz svaki pojedinacan mnozac



            //https://en.wikipedia.org/wiki/Gradient_descent
            //df/dx1, df/dx2...
            this.gradients.Add(dw);

            return dw;
        }

        public void updateWeights(double learning_rate, double momentum)
        {
            for (int i = 0; i < multiplyNodes.Count; i++)
            {
                List<double> grad = this.gradients.Select(gradient => gradient[i]).ToList();
                double meanGradient = grad.Sum() / this.gradients.Count;
                double delta = learning_rate * meanGradient + momentum * this.previous_deltas[i];
                this.previous_deltas[i] = delta;
                this.multiplyNodes[i].x[1] -= delta; //koriguj tezine 
            }
            //reset gradijenata
            this.gradients.Clear();
        }
    }
}
