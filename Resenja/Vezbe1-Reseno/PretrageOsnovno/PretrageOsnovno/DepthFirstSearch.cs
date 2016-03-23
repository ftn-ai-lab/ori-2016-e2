using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PretrageOsnovno
{
    class DepthFirstSearch
    {
        public State search(State pocetno)
        {
            List<State> stanjaZaObradu = new List<State>();

            //TODO 6: Implementirati Prvi u dubinu
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

                stanjaZaObradu.InsertRange(0, mogucaSledecaStanja); // dfs
            }

            return null;
        }
    }
}