using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasinskoUcenje
{
    public class LinearRegression
    {
        public double k { get; set; }
        public double n { get; set; }

	    public void fit(double[] x, double[] y) {
            // TODO 2: implementirati fit funkciju koja odredjuje parametre k i n
            // y = kx + n
		   
	    }

        public double predict(double x)
        {   
            // TODO 3: Implementirati funkciju predict koja na osnovu x vrednosti vraca
            // predvinjenu vrednost y
            return 0;
        }
    }
}
