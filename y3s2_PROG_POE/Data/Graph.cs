using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace y3s2_PROG_POE.Data
{
    public class Graph<T>
    {
        private Dictionary<T, List<T>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<T, List<T>>();
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Adds a node to the list of nodes in the graph
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(T node)
        {
            if (!adjacencyList.ContainsKey(node))
            {
                adjacencyList[node] = new List<T>();
            }
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Creates an edge between two nodes in the graph
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void AddEdge(T from, T to)
        {
            if (adjacencyList.ContainsKey(from) && adjacencyList.ContainsKey(to))
            {
                adjacencyList[from].Add(to);
                adjacencyList[to].Add(from); // Assuming an undirected graph
            }
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Method returns a list of nodes in the graph in depth-first order
        /// </summary>
        /// <param name="startNode"></param>
        /// <returns></returns>
        public List<T> BreadthFirstTraversal(T startNode)
        {
            List<T> result = new List<T>();
            if (!adjacencyList.ContainsKey(startNode))
                return result;

            HashSet<T> visited = new HashSet<T>();
            Queue<T> queue = new Queue<T>();

            visited.Add(startNode);
            queue.Enqueue(startNode);

            while (queue.Count > 0)
            {
                T currentNode = queue.Dequeue();
                result.Add(currentNode);

                foreach (T neighbor in adjacencyList[currentNode])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return result;
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// method returns a list of nodes in the graph in breadth-first order
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<T> GetNeighbors(T node)
        {
            if (adjacencyList.ContainsKey(node))
            {
                return adjacencyList[node];
            }
            return new List<T>();
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// Returns a list of all nodes in the graph
        /// </summary>
        /// <returns></returns>
        public List<T> GetNodes()
        {
            return adjacencyList.Keys.ToList();
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------*/

    }
}
/*-----------------------------------------------------------------End of File--------------------------------------------------------------------------*/

