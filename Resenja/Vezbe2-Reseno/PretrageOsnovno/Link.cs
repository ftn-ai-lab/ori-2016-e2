using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretrageOsnovno
{
    class Link
    {
        public Node StartNode { get; set; }
        public Node EndNode { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }

        public Link(Node startNode, Node endNode, string name, double cost)
        {
            this.StartNode = startNode;
            this.EndNode = endNode;
            this.Name = name;
            this.Cost = cost;
        }
    }
}
