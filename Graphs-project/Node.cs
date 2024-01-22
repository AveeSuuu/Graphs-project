using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_project
{
  internal class Node
  {
    private static uint nodeIdCounter = 1;
    public uint NodeID { get; }
    public Point Position { get; }
    public HashSet<Node> Neighbours { get; }

    private Node()
    {
      NodeID = nodeIdCounter++;
      Neighbours = new HashSet<Node>();
    }

    public Node(Point position): base()
    {
      Position = position;
    }

    public Node(int x, int y): base()
    {
      Position = new Point(x, y);
    }

    public void addNeigbour(Node edge)
    {
      Neighbours.Add(edge);
    }

    public Point getMiddlePoint(int radius)
    {
      return new Point(Position.X - radius, Position.Y - radius);
    }

    public static void resetIdCounter()
    {
      nodeIdCounter = 1;
    }
  }
}
