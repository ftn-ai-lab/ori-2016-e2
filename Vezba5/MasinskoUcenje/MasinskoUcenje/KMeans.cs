using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasinskoUcenje
{
    public class KMeans
    {
        public List<Point> elementi = new List<Point>();
        public List<Cluster> grupe = new List<Cluster>();
        public int brojGrupa = 0;
        Random rnd = new Random();

        public void podeliUGrupe(int brojGrupa, double errT)
        {
            this.brojGrupa = brojGrupa;
            if (brojGrupa == 0) return;
            //------------  inicijalizacija -------------
            for (int i = 0; i < brojGrupa; i++)
            {
                // TODO 5: na slucajan nacin inicijalizovati centre grupa   
            }
            //------------- iterativno racunanje centara ---
            for (int it = 0; it < 1000; it++)
            {
                foreach (Cluster grupa in grupe)
                    grupa.elementi = new List<Point>();

                foreach (Point cc in elementi)
                {
                    int najblizaGrupa = 0;
                    for (int i = 0; i < brojGrupa; i++)
                    {
                        if (grupe[najblizaGrupa].rastojanje(cc) >
                            grupe[i].rastojanje(cc))
                        {
                            najblizaGrupa = i;
                        }
                    }
                    grupe[najblizaGrupa].elementi.Add(cc);
                }
                double err = 0;
                for (int i = 0; i < brojGrupa; i++)
                {
                    err += grupe[i].pomeriCentar();
                }
                if (err < errT)
                    break;
            }
        }
    }

    public class Cluster
    {
        public Point centar = new Point(0,0);
        public List<Point> elementi = new List<Point>();

        public double rastojanje(Point c)
        {   // TODO 6: implementirati funkciju rastoajanje
            return 0;
        }

        public double pomeriCentar()
        {   // TODO 7: implemenitrati funkciju koja pomera centre klastera
            double sX = 0;
            double sY = 0;
            double retVal = 0;
            
            return retVal;
        }
    }
}
