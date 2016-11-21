using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Vertex
    {
        public int data;
        public List<Vertex> neigbors;

        public Vertex()
        {
        }

        public Vertex(int data)
        {
            this.data = data;
        }
    }   
}
