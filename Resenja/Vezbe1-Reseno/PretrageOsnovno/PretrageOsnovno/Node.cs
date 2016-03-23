using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretrageOsnovno
{
    class Node
    {
        private string name;

        public Node (string name)
	    {
            this.name = name;
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

            return name.Equals(n.name);
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override String ToString()
        {
            return name;
        }
    }
}
