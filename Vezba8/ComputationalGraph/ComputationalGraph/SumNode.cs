using System.Collections.Generic;
using System.Linq;

namespace ComputationalGraph
{
    public class SumNode
    {
        private List<double> x;

        public SumNode()
        {
            x = new List<double>();
        }
        /// <summary>
        /// Suma svih elemenata
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double forward(List<double> x)
        {
            this.x = x;
            return x.Sum();
        }
        /// <summary>
        /// Izvod funkcije po svakom elementu
        /// z = x + y 
        /// dz/dx = 1 => dx = dz
        /// dz/dy = 1 => dy = dz
        /// </summary>
        /// <param name="dz"></param>
        /// <returns></returns>
        public List<double> backward(double dz)
        {
            return x.Select(xx => xx = dz).ToList();
        }
    }
}
