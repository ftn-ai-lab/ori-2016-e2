using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PretrageOsnovno
{
    class AStarSearch
    {
        public State Search(string startNodeName, string endNodeName)
        {
            Node startNode = Program.instance.graph[startNodeName];
            Node endNode = Program.instance.graph[endNodeName];

            List<State> zaObradu = new List<State>();
            List<State> obradjeno = new List<State>();

            zaObradu.Add(new State(startNode));

            while (zaObradu.Count > 0)
            {
                // find state with mininum total cost value
                State current = null;
                double minTotalCost = double.MaxValue;
                foreach (State state in zaObradu)
                {
                    double totalCost = state.Cost + state.Node.Heuristic;
                    if (totalCost < minTotalCost)
                    {
                        minTotalCost = totalCost;
                        current = state;
                    }
                }
                zaObradu.Remove(current);

                obradjeno.Add(current);

                if (current.Node.Name == endNode.Name)
                {
                    return current;
                }

                List<State> nextStates = current.children();
                foreach (State state in nextStates)
                {
                    if (obradjeno.Contains(state))
                        continue;

                    if (!zaObradu.Contains(state))
                    {
                        zaObradu.Add(state);
                    }
                }

            }

            return null;
        }

    }
}
