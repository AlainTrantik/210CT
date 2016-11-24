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
            Vertex one=new Vertex(1); //I add 5 nodes without any edges for the moment
            Vertex two = new Vertex(2);
            Vertex three = new Vertex(3);
            Vertex four = new Vertex(4);
            Vertex five = new Vertex(5);

            one.neigbors.Add(two); //Node 1 is linked to Node 2

            two.neigbors.Add(one); //Node 2 is linked to Node 1 and four ...
            two.neigbors.Add(four);

            three.neigbors.Add(four);
            three.neigbors.Add(five);

            Vertex[] vertices = { two, three };
            four.Add(vertices); //I use my function Add to create edges
            four.neigbors.Add(five);

            five.neigbors.Add(three);
            five.neigbors.Add(four);

            //Finally I have the unweighted undiricted graph of the page 22 of the lecture on graphs
        }
    }
}
