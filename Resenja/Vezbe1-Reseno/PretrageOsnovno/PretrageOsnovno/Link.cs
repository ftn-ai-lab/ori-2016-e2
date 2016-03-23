using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretrageOsnovno
{
    class Link
    {
        private Node startNode;
        private Node endNode;
        private string name;

        public Link(Node startNode, Node endNode)
        {
            this.startNode = startNode;
            this.endNode = endNode;
        }

        public string Name 
        { 
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            } 
        }
    }
}
