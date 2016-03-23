using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PretrageOsnovno
{
    class Program
    {
        public static Graph instance = null;
        static void Main(string[] args)
        {
            string[] linesLinks = System.IO.File.ReadAllLines(@".\..\..\Graphs\Graph.txt");
            string[] linesNodes = System.IO.File.ReadAllLines(@".\..\..\Graphs\Nodes.txt");
            instance = new Graph(linesNodes, linesLinks);

            //ispisuje sadrzaj grafa u konzoli
            instance.printGraph();

            AStarSearch aStarSearch = new AStarSearch();
            BreadthFirstSearch bfs = new BreadthFirstSearch();
            DepthFirstSearch dfs = new DepthFirstSearch();
            IterativeDepthFirstSearch idfs = new IterativeDepthFirstSearch();

            State solution = aStarSearch.Search("NS", "NI");

            List<State> resenje = new List<State>();
            if (solution != null)
            {
                resenje = solution.path();
            }

            #region ispis i snimanje resenja u datoteku

            Console.WriteLine("Konacno resenje : ");
            string output = "";
            State last = resenje.Last();
            foreach (State r in resenje)
            {
                Console.WriteLine(r.Node.ToString());
                output += r.Node.ToString();
                if(!last.Equals(r))
                {
                    output += ",";
                }

            }
            System.IO.File.WriteAllText(@".\..\..\Graphs\Resenje.txt", output);
            #endregion

            // Zadrzava otvorenu konzolu u debug modu
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
