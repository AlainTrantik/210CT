using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
// I chose the adjacency list approach so I created a new class Vertex (Node) with a label and a list of vertices representing the edges. 
    /*  
     * class Vertex
     *      label <- 0
     *      edges <- []
     *      
     *   addEdge(node)
     *      if(node!=null)
     *          egdes.Add.node
     *          return TRUE
     *      return FALSE
     * 
     * */


    class Vertex
    {
        public int label;
        public List<Vertex> edges = new List<Vertex>();

        public Vertex()
        {
        }

        public Vertex(int data)//Constructor to Create/Add a new node
        {
            this.label = data;
        }

        //Getter and Setter
        public int Data
        {
            get
            {
                return label;
            }
            set
            {
                this.label = value;
            }
        }

        public List<Vertex> Edges
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
        //Function to add an edge, I add the node in the adjacency list of both nodes with the other one
        public bool addEdge(Vertex node)
        {
            if (node != null)
            {
                edges.Add(node);
                return true;
            }
            return false;
         }
    }   
}
