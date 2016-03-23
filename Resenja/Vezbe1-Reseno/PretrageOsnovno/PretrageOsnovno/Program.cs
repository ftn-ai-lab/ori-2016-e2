using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PretrageOsnovno
{
    class Program
    {
        public static Node endNode = new Node("j");
        public static Graph instance = null;
        static void Main(string[] args)
        {
            //TODO 1: Ucitati datoteku Graph1.txt i proslediti klasi Graph
            string[] lines = File.ReadAllLines(@"./Graphs/Graph1.txt");
            instance = new Graph(lines);

            List<State> resenje = new List<State>();
            //DepthFirstSearch dfs = new DepthFirstSearch();
            BreadthFirstSearch bfs = new BreadthFirstSearch();

            State startState = new State();
            Node startNode = instance.graph.Keys.First();
            startState.node = startNode;

            State sp = startState;
            State solution = bfs.search(sp);

            //ispisuje sadrzaj grafa u konzoli
            //i snima u datoteku
            instance.printGraph();

            if (solution != null)
            {
                resenje = solution.path();
                foreach (State st in resenje)
                {
                    Console.WriteLine(st.node);
                }
            }

            //TODO 8: Snimiti resenje u tekstualnu datoteku
            List<string> linesOutput = new List<string>();
            foreach (State st in resenje)
            {
                linesOutput.Add(st.node.ToString());
            }
            File.WriteAllLines("Solution.txt", linesOutput);

            // Zadrzava otvorenu konzolu u debug modu
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
