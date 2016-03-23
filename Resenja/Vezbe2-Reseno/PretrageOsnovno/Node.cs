using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretrageOsnovno
{
    class Node
    {
        public string Name { get; set; }
        public double Heuristic { get; set; }
        public List<Link> Links { get; set; }

        public Node (string name, double heuristic)
	    {
            this.Name = name;
            this.Heuristic = heuristic;
            this.Links = new List<Link>();
	    }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Node n = obj as Node;
            if ((System.Object)n == null)
                return false;

            return Name.Equals(n.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override String ToString()
        {
            return Name;
        }
    }
}
