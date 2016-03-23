using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretrageOsnovno
{
    class Graph
    {
        public Dictionary<string, Node> graph = null;

        public Graph(string[] linesNodes, string[] linesLinks)
        {
            graph = new Dictionary<string, Node>();
            formGraph(linesNodes, linesLinks);
        }

        private void formGraph(string[] linesNodes, string[] linesLinks)
        {
            foreach (string line in linesNodes)
            {
                string[] splittedLine = line.Split(':');
                string nodeName = splittedLine[0];
                string nodeHeuristicStr = splittedLine[1];
                double nodeHeuristic = double.Parse(nodeHeuristicStr);

                Node node = new Node(nodeName, nodeHeuristic);
                graph.Add(node.Name, node);
            }

            foreach (string line in linesLinks)
            {
                string[] splittedLine = line.Split(':');
                string[] splittedLineNodes = splittedLine[1].Split(',');

                string linkName = splittedLine[0];
                string startNodeName = splittedLineNodes[0];
                string endNodeName = splittedLineNodes[1];
                string linkCostStr = splittedLineNodes[2];
                double linkCost = double.Parse(linkCostStr);

                Node startNode = graph[startNodeName];
                Node endNode = graph[endNodeName];

                Link link = new Link(startNode, endNode, linkName, linkCost);
                startNode.Links.Add(link);
            }
        }

        #region ispis
        public void printGraph()
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, Node> kvp in graph)
            {
                foreach (Link link in kvp.Value.Links)
                {
                    Console.WriteLine(link.Name + ":" + link.StartNode + "," + link.EndNode + "," + link.Cost);
                }
            }
        }
        #endregion
    }
}
