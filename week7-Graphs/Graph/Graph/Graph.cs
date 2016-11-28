using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    /* class Graph
     *      vertices <- []
     *      
     *   addNode(v)
     *      if(v!=null)
     *          vertices.Add(v)
     *          return TRUE
     *      return FALSE
     * 
     * */
    class Graph
    {
        public List<Vertex> vertices = new List<Vertex>();

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

        //To add a node a simply add it the list of nodes
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
