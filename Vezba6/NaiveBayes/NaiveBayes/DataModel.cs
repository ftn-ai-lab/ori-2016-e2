using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NaiveBayes
{
    public class DataModel
    {
        public List<int> Sentiment { get; set; }
        public List<string> Text { get; set; }

        public DataModel()
        {
            this.Sentiment = new List<int>();
            this.Text = new List<string>();
        }

    }
}
