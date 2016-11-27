using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
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
            Vertex ten = new Vertex(10);

            one.addEdge(2); //Node 1 is linked to Node 2

            two.addEdge(1); //Node 2 is linked to Node 1 and four ...
            two.addEdge(4);

            three.addEdge(4);
            three.addEdge(5);

            four.addEdge(2); //I use my function Add to create edges
            four.addEdge(3);
            four.addEdge(5);

            five.addEdge(3);
            five.addEdge(4);
            Graph myGraph = new Graph();

            Vertex[] v = { one, two, three, four, five };
            myGraph.addNodes(v);
            //Finally I have the unweighted undiricted graph of the page 22 of the lecture on graphs
        }
    }
}
