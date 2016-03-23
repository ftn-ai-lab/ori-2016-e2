using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretrageOsnovno
{
    class State
    {
        State parent;
        public Node node;
        public State nextState(Node node)
        {
            State nextState = new State();
            nextState.node = node;
            nextState.parent = this;
            return nextState;
        }

        // Metoda odredjuje sledece cvorove u koje je moguce preci iz trenutnog cvora
        //TODO 4: Dopuniti metodu
        public List<State> children()
        {
            List<State> children = new List<State>();

            if (Program.instance.graph.ContainsKey(node))
            {
                List<Node> endNodes = Program.instance.graph[node];
                foreach (Node endNode in endNodes)
                {
                    State nextSt = nextState(endNode);
                    children.Add(nextSt);
                }
            }

            return children;
        }

        public override int GetHashCode()
        {
            return node.GetHashCode() * 100;
        }

        public bool isFinalState()
        {
            return node.Equals(Program.endNode);
        }

        public List<State> path()
        {
            List<State> path = new List<State>();
            State tt = this;
            while (tt != null)
            {
                path.Insert(0, tt);
                tt = tt.parent;
            }
            return path;
        }
    }
}
