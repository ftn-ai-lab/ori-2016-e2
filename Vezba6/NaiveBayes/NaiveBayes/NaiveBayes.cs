using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NaiveBayes
{
    public class NaiveBayes
    {
        Dictionary<int, double> sentiment_words_count = new Dictionary<int, double>();
        public static Dictionary<string, int> vocabulary = new Dictionary<string, int>();
        public static Dictionary<int, Dictionary<string, int>> word_counts = new Dictionary<int, Dictionary<string, int>>();

        public NaiveBayes()
        {
            sentiment_words_count[0] = 0.0;
            sentiment_words_count[1] = 0.0;
            word_counts[0] = new Dictionary<string, int>();
            word_counts[1] = new Dictionary<string, int>();
        }
        /// <summary>
        /// Formiranje globalnog recnika, recnika iz pozitivnih i negativnih recenzija 
        /// </summary>
        /// <param name="model">train model ucitan iz tsv datoteke</param>
        public void fit(DataModel model)
        {
            for (int i = 0; i < model.Text.Count; i++)
            {
                string text = model.Text[i];
                int sentiment = model.Sentiment[i];

                sentiment_words_count[sentiment] += 1;
                string[] words = TextUtil.Tokenize(text);
                Dictionary<string, int> counts = TextUtil.CountWords(words);

                foreach (KeyValuePair<string, int> item in counts)
                {
                    string word = item.Key;
                    int count = item.Value;

                    //TODO 5 - Popuniti globalni recnik svih reci, kao i recnike za odredjene sentimente

                }
            }
        }
        /// <summary>
        /// Racunanje verovatnoca za prosledjeni tekst
        /// </summary>
        /// <param name="text">Tekst koji se klasifikuje</param>
        public void predict(string text)
        {
            string[] words = TextUtil.Tokenize(text);
            var counts = TextUtil.CountWords(words);

            double wordCount = sentiment_words_count.Values.Sum();
            //TODO 6 - Izracunati verovatnoce da je rec pozitivnog ili negativnog sentimenta - P(cj)
            double Pcj_neg;
            double Pcj_pos;


            double log_prob_neg = 0.0;
            double log_prob_pos = 0.0;

            foreach (KeyValuePair<string, int> item in counts)
            {
                string w = item.Key;
                int cnt = item.Value;
                if (!vocabulary.ContainsKey(w) || w.Length <= 3)
                    continue;
                //TODO 7.1 - Iterativno racunati logaritamski zbir verovatnoca sentimenta svake reci
                
            }

            //TODO 7.2 Izracunati konacnu vrednost verovatnoce sentimenta prosledjenog teksta

            //TODO 8 - Ispisati vrednosti predikcije za pozitivan i negativan sentiment teksta
        }
    }
}
