using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


namespace NaiveBayes
{
    public static class TextUtil
    {
        /// <summary>
        /// Ucitava skup podataka i popunjava model podataka. 
        /// </summary>
        /// <param name="name">Naziv fajla u data direktorijumu</param>
        /// <returns>Model podataka sa popunjenim podacima</returns>
        public static DataModel LoadData(string name)
        {
            DataModel dataModel = new DataModel();
            string fileName = string.Format(@"./data/{0}", name);
            string[] lines = File.ReadAllLines(fileName);

            //TODO 1 - implementirati metodu koja ucitava podatke iz tsv fajla i smesta ih u odgovarajuce atribute data modela

            return dataModel;
        }

        /// <summary>
        /// Metoda za uklanjanje znakova interpunkcije iz teksta.
        /// Npr. "Milan,Darko i Ivan polazu kolokvijum!" ce biti transformisan u
        /// "Milan Darko i Ivan polazu kolokvijum"
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Tekst bez znakova interpunkcije</returns>
        public static string RemovePunctuation(string text)
        {   
            //TODO 2 - Ukloniti znakove interpunkcije iz teksta
            string retVal = null;

            return retVal;
        }

        /// <summary>
        /// Tokenizacija teksta na reci. Pre razdvajanja teksta na reci (tokene),
        /// potrebno je ukloniti sve znake interpunkcije i pretvoriti 
        /// sva slova u mala. 
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Niz tokena (reci)</returns>
        public static string[] Tokenize(string text)
        {   
            //TODO 3 - implementirati tokenizaciju teksta na reci 
            text = RemovePunctuation(text);
            text = text.ToLower();
            string[] tokens = null;

            return tokens;
        }
        /// <summary>
        /// Metoda za brojanje reci u teksu. Formira se recnik ciji je kljuc
        /// sama rec, a vrednost broj pojavljivanja te reci.
        /// Npr za niz reci: ["rec1", "rec2", "rec1"] bice formiran recnik
        ///     { "rec1" : 2,
        ///       "rec2" : 1   
        ///     } 
        /// </summary>
        /// <param name="words">Niz reci</param>
        /// <returns></returns>
        public static Dictionary<string, int> CountWords(string[] words)
        {   
            //TODO 4 - Formirati recnik koji sadrzi broj pojavljivanja svake reci iz niza reci words
            Dictionary<string, int> vocabulary = new Dictionary<string, int>();

            return vocabulary;

        }
    }
}
