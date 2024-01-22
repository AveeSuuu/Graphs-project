using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_project
{
  internal class GraphOperations
  {
    private Graph graph;
    private int radius;

    public GraphOperations(Graph graph, int radius)
    {
      this.graph = graph;
      this.radius = radius;
    }

    public void addNode(Point point)
    {
      if (nodesNearPoint(point)) return;
      if (pointOutOfZone(point)) return;

      graph.nodes.Add(new Node(point));
    }

    public void connect(Node firstNode, Node secondNode)
    {
      if (nodeNotFound(firstNode)) return;
      if (nodeNotFound(secondNode)) return;

      firstNode.addNeigbour(secondNode);
      secondNode.addNeigbour(firstNode);
    }

    public Node getNearestNode(Point point)
    {
      foreach (Node node in graph.nodes)
      {
        if (distance(point, node.Position) < radius) return node;
      }

      return null;
    }

    private bool nodeNotFound(Node node)
    {
      return node == null ? true : false;
    }

    private bool nodesNearPoint(Point point)
    {
      foreach (Node node in graph.nodes)
      {
        if (distance(point, node.Position) < radius * 2.5) return true;
      }

      return false;
    }

    private bool pointOutOfZone(Point point)
    {
      return
        point.X < 30  ||
        point.X > 470 ||
        point.Y < 30  ||
        point.Y > 470
      ? true : false;
    }

    private int distance(Point p1, Point p2)
    {
      return (int)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + (int)Math.Pow(p2.Y - p1.Y, 2));
    }
  }
}
