using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NaiveBayes
{
    class Program
    {
        static void Main(string[] args)
        {
            NaiveBayes textClassification = new NaiveBayes();
            DataModel train = TextUtil.LoadData("train.tsv");
             
            textClassification.fit(train);
            textClassification.predict("This movie was bad.");

            Console.ReadLine();
        }
    }
}
