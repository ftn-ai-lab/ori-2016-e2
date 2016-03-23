using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PretrageOsnovno
{
    class IterativeDepthFirstSearch
    {
        private const int MaxLevel = 10000;

        public State Search(string startNodeName, string endNodeName)
        {
            Node startNode = Program.instance.graph[startNodeName];
            Node endNode = Program.instance.graph[endNodeName];

            for (int i = 1; i < MaxLevel; i++)
            {
                List<State> stanjaZaObradu = new List<State>();
                stanjaZaObradu.Add(new State(startNode));

                while (stanjaZaObradu.Count > 0)
                {
                    State naObradi = stanjaZaObradu[0];
                    stanjaZaObradu.Remove(naObradi);

                    if (naObradi.Level > i)
                        continue;
                    
                    if (naObradi.Node.Name == endNode.Name)
                    {
                        return naObradi;
                    }
                    else
                    {
                        List<State> mogucaSledecaStanja = naObradi.children();
                        stanjaZaObradu.InsertRange(0, mogucaSledecaStanja);
                    }
                    
                }
            }
            return null;
        }
    }
}
