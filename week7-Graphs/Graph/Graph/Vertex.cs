using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{/// <summary>
/// I chose the adjacency list approach so I created a new class Vertex (Node) with a data and a list of vertices representing the neighbors. 
/// </summary>
    class Vertex
    {
        public int data;
        public List<int> edges;

        public Vertex()
        {
        }

        public Vertex(int data)//Constructor to Create/Add a new node
        {
            this.data = data;
        }

        //Getter and Setter
        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                this.data = value;
            }
        }

        public List<int> Neighbors
        {
            get
            {
                return edges;
            }
            set
            {
                this.edges = value;
            }
        }
        public bool addEdge(int node)
        {
            if (node != null)
            {
                this.edges.Add(node);
                return true;
            }
            return false;
        }
    }   
}
