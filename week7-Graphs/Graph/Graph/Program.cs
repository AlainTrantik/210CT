using System;
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
                Console.WriteLine(v.data);
        }
        static List<Vertex> DFS(Graph G, Vertex v)
        {
            Stack<Vertex> S = new Stack<Vertex>();
            List<Vertex> visited = new List<Vertex>();
            S.Push(v);
            while (S.Count != 0)
            {
                 Vertex u = S.Pop();
                 if(!visited.Contains(u))
                 {
                     visited.Add(u);
                     //FOR ALL EDGES e, FROM u, S.PUSH(e.to)
                 }
            }
            return visited;
        }

        static List<Vertex> BFS(Graph G, Vertex v)
        {
            Queue<Vertex> Q = new Queue<Vertex>();
            List<Vertex> visited = new List<Vertex>();
            Q.Enqueue(v);
            while (Q.Count != 0)
            {
                Vertex u = Q.Dequeue();
                if (!visited.Contains(u))
                {
                    visited.Add(u);
                }
                //FOR ALL EDGES e, FROM u, Q.enqueue(e.to)
            }
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

            one.addEdge(2); //Node 1 is linked to Node 2

            two.addEdge(1); //Node 2 is linked to Node 1 and four ...
            two.addEdge(4);

            four.addEdge(2); //I use my function Add to create edges
            four.addEdge(3);
            four.addEdge(5);

            three.addEdge(4);
            three.addEdge(5);

            five.addEdge(3);
            five.addEdge(4);
            five.addEdge(6);

            six.addEdge(5);
            six.addEdge(7);
            six.addEdge(8);

            seven.addEdge(6);
            seven.addEdge(8);

            eight.addEdge(6);
            eight.addEdge(7);
            eight.addEdge(9);

            nine.addEdge(8);
            
            Graph myGraph = new Graph();

            Vertex[] v = { one, two, three, four, five, six, seven, eight, nine}; //I add all the nodes to the graph
            myGraph.addNodes(v);

            Vertex ten = new Vertex(10);

            nine.addEdge(10); //I create a new node and link it with node 9 by adding a new edge
            ten.addEdge(9);

            myGraph.addNode(ten); //I add it to the graph
        }
    }
}
