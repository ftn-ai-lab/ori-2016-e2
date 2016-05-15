using System;

namespace ComputationalGraph
{
    public class SigmoidNode
    {
        private double x;
        /// <summary>
        /// Sigmoid funkcija 1/1+e^-x
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private double sigmoid(double x)
        {
            return 1.0 / (1 + Math.Exp(-x));
        }

        public SigmoidNode()
        {
            this.x = 0;
        }

        /// <summary>
        /// Na dobijeno x pozvati sigmoid funkciju
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double forward(double x)
        {
            this.x = x;
            return this.sigmoid(this.x);
        }

        /// <summary>
        /// z = 1/1+e^-x
        /// dz/dx = sigm(x)*(1-sigm(x))
        /// =>dx = dz * sigm(x)*(1-sigm(x))
        /// </summary>
        /// <param name="dz"></param>
        /// <returns></returns>
        public double backward(double dz)
        {
            return dz * this.sigmoid(this.x) * (1.0 - this.sigmoid(this.x));
        }

        
    }
}
