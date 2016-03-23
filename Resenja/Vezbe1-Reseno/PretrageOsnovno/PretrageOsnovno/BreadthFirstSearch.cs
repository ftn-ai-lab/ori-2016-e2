using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretrageOsnovno
{
    class BreadthFirstSearch
    {
        public State search(State pocetno)
        {
            List<State> stanjaZaObradu = new List<State>();

            //TODO 7: Implementirati prvi u sirinu
            stanjaZaObradu.Add(pocetno);

            while (stanjaZaObradu.Count > 0)
            {
                State naObradi = stanjaZaObradu[0];
                
                if (naObradi.isFinalState())
                {
                    return naObradi;
                }
                stanjaZaObradu.RemoveAt(0);
                List<State> mogucaSledecaStanja = naObradi.children();

                stanjaZaObradu.AddRange(mogucaSledecaStanja); // bfs
            }

            return null;
        }
    }
}
