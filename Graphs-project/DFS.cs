using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Graphs_project
{
  internal class DFS : Algorithm
  {
    public DFS(Graph graph) : base(graph) { }

    public override void search()
    {
      Node start = GraphOperations.getStartNode(graph);
      dfsSearch(start, new HashSet<Node>());
    }

    private void dfsSearch(Node node, HashSet<Node> visitedNodes) 
    {
      

      if (node == null || visitedNodes.Contains(node)) return;

      visitedNodes.Add(node);

      foreach(Node neighbour in node.Neighbours)
      {
        dfsSearch(neighbour, visitedNodes);
      }
    }
  }
}
