using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph
    {
        public List<Vertex> vertices;

        public Graph()
        {
        }

        public List<Vertex> Vertices
        {
            get
            {
                return this.vertices;
            }
            set
            {
                this.vertices = value;
            }
        }
        public bool addNode(Vertex v)
        {
            if (v != null)
            {
                this.vertices.Add(v);
                return true;
            }
            return false;
        }

        public void addNodes(Vertex[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                addNode(v[i]);
            }
        }
    }
}
