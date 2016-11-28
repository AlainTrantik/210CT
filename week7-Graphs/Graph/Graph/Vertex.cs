using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
// I chose the adjacency list approach so I created a new class Vertex (Node) with a data and a integer list representing the edges. 
    /*  
     * class Vertex
     *      data <- 0
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
        public int data;
        public List<int> edges = new List<int>();

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
        //Function to add an edge, I add the value of the node in the adjacency list of both nodes with the other one
        public void addEdge(int node)
        {
            edges.Add(node);
         }
    }   
}
