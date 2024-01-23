using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_project
{
  internal class BFS : Algorithm
  {
    public BFS(Graph graph) : base(graph) { }

    public override void search()
    {
      Node start = GraphOperations.getStartNode(graph);
      bfsSearch(start);
    }

    private void bfsSearch(Node startNode)
    {
      HashSet<Node> visitedNodes = new HashSet<Node>();
      Queue<Node> queue = new Queue<Node>();

      queue.Enqueue(startNode);
      visitedNodes.Add(startNode);

      while(queue.Count > 0 )
      {
        Node current = queue.Dequeue();
        Steps.Enqueue(current);

        foreach(Node neighbour in current.Neighbours)
        {
          if (!visitedNodes.Contains(neighbour))
          {
            queue.Enqueue(neighbour);
            visitedNodes.Add(neighbour);
            Steps.Enqueue(neighbour);

          }
        }
      }
    }
  }
}
