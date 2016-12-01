using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void displayList(List<Vertex> l)
        {
            foreach (Vertex v in l)
                Console.WriteLine(v.label); 
        }
        static void saveToText(List<Vertex> vs,string fileName) //Function to save a List of vertices in a text file
        {
            string path = @"h:\"+fileName+".txt"; //location of the file
            List<int> values = new List<int>(); //I create an list of integers and fill it with the label of each vertex in the list of vertices
            foreach(Vertex v in vs)
            {
                values.Add(v.label);
            }
            //The File.WriteAllLines C# function needs a string array in parameter so I convert my list of integers in a string array
            string [] array = values.Select(x => x.ToString()).ToArray(); 
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                File.WriteAllLines(path, array);
            }
        }
        static List<Vertex> DFS(Graph G, Vertex v)
        {
            Console.WriteLine("DFS traversal");
            Stack<Vertex> S = new Stack<Vertex>();
            List<Vertex> visited = new List<Vertex>();
            S.Push(v);
            while (S.Count != 0)
            {
                 Vertex u = S.Pop();
                 if(!visited.Contains(u))
                 {
                    visited.Add(u);
                    foreach (Vertex e in u.edges)
                        S.Push(e);
                }
            }
            saveToText(visited,"DFS");
            return visited;
        }

        static List<Vertex> BFS(Graph G, Vertex v)
        {
            Console.WriteLine("BFS traversal");
            Queue<Vertex> Q = new Queue<Vertex>();
            List<Vertex> visited = new List<Vertex>();
            Q.Enqueue(v);
            while (Q.Count != 0)
            {
                Vertex u = Q.Dequeue();
                if (!visited.Contains(u))
                {
                    visited.Add(u);
                    foreach (Vertex e in u.edges)
                        Q.Enqueue(e);
                }
            }
            saveToText(visited,"BFS");
            return visited;
        }

        static void Main(string[] args)
        {
            Vertex one=new Vertex(1); //I create 10 nodes
            Vertex two = new Vertex(2);
            Vertex three = new Vertex(3);
            Vertex four = new Vertex(4);
            Vertex five = new Vertex(5);
            Vertex six = new Vertex(6);
            Vertex seven = new Vertex(7);
            Vertex eight = new Vertex(8);
            Vertex nine = new Vertex(9);

            one.addEdge(two); //Node 1 is linked to Node 2

            two.addEdge(one); //Node 2 is linked to Node 1 and four ...
            two.addEdge(four);

            four.addEdge(two);
            four.addEdge(three);
            four.addEdge(five);

            three.addEdge(four);
            three.addEdge(five);

            five.addEdge(three);
            five.addEdge(four);
            five.addEdge(six);

            six.addEdge(five);
            six.addEdge(seven);
            six.addEdge(eight);

            seven.addEdge(six);
            seven.addEdge(eight);

            eight.addEdge(six);
            eight.addEdge(seven);
            eight.addEdge(nine);

            nine.addEdge(eight);
            
            Graph myGraph = new Graph();

            Vertex[] v = { one, two, three, four, five, six, seven, eight, nine}; //I add all the nodes to the graph
            myGraph.addNodes(v);

            Vertex ten = new Vertex(10);

            nine.addEdge(ten); //I create a new node and link it with node 9 by adding it in the edges list of node 9, i don't forget to add node 10 to the egdes list of node 9
            ten.addEdge(nine);

            myGraph.addNode(ten); //I add it to the graph
            displayList(DFS(myGraph, one)); //Display myGraph by a DFS beginning with node one
            displayList(BFS(myGraph, one)); //Display myGraph by a BFS beginning with node one
            Console.ReadLine();
        }
    }
}
