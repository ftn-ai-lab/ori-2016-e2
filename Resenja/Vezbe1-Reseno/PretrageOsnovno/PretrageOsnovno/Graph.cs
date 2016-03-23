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
        public Dictionary<Node, List<Node>> graph;

        public Graph(string[] lines)
        {
            graph = new Dictionary<Node, List<Node>>();
            formGraph(lines);
        }

        //TODO 2 : Implementirati metodu
        private void formGraph(string[] lines)
        {
            foreach (string line in lines)
            {
                string[] firstSplit = line.Split(':');
                string[] secondSplit = firstSplit[1].Split(',');

                Node startNode = new Node(secondSplit[0]);
                Node endNode = new Node(secondSplit[1]);

                if (!graph.ContainsKey(startNode))
                {
                    graph.Add(startNode, new List<Node>());
                }
                graph[startNode].Add(endNode);
            }
        }

        //TODO 3: Implementirati metodu koja prolazi kroz graph, cita njegov sadrzaj i upisuje u datoteku
        public void printGraph()
        {
            List<string> lines = new List<string>();
            foreach (KeyValuePair<Node, List<Node>> pair in graph)
            {
                foreach (Node child in pair.Value)
                {
                    string line = "veza:" + pair.Key.ToString()
                        + "," + child.ToString();
                    lines.Add(line);
                }
            }
           
            File.WriteAllLines(@"./Graphs/Graph22.txt", lines);
        }
    }
}
