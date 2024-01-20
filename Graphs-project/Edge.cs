using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_project
{
  internal class Edge
  {
    private static uint nextId = 1;
    private uint edgeID;
    private Point position;
    private HashSet<Edge> neighbours;

    public Edge(Point position)
    {
      edgeID = nextId;
      nextId++;
      this.position = position;
      neighbours = new HashSet<Edge>();
    }

    public Edge(int x, int y)
    {
      edgeID = nextId;
      nextId++;
      this.position = new Point(x, y);
      neighbours = new HashSet<Edge>();
    }

    public uint EdgeID
    {
      get { return edgeID; }
    }

    public Point Position
    {
      get { return position; }
    }

    public HashSet<Edge> Neighbours
    {
      get { return neighbours; }
    }

    public void addNeigbour(Edge edge)
    {
      neighbours.Add(edge);
    }

    public Point getMiddlePoint(int radius)
    {
      return new Point(position.X - radius, position.Y - radius);
    }

    public static void resetIdCounter()
    {
      nextId = 1;
    }
  }
}
