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
            Vertex one=new Vertex();
            one.data = 1;
            Vertex two = new Vertex(2);
            Vertex three = new Vertex(3);
            Vertex four = new Vertex(4);

            one.neigbors.Add(two);
            one.neigbors.Add(three);

            two.neigbors.Add(one);
            two.neigbors.Add(three);

            three.neigbors.Add(one);
            three.neigbors.Add(two);
            three.neigbors.Add(four);

            four.neigbors.Add(three);

        }
    }
}
