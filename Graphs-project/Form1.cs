using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Graphs_project
{
  public partial class GraphsMainForm : Form
  {
    Graph graph;
    DrawingKit drawingKit;
    Point mousePosition;

    public GraphsMainForm()
    {
      InitializeComponent();
      graph = new Graph(drawingZone);
      drawingKit = new DrawingKit(drawingZone);
      mousePosition = new Point();
    }

    private void drawingZone_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        if (!checkColision(e.Location)) return;

        graph.nodes.Add(new Node(e.X, e.Y));
        drawingKit.draw(graph.nodes);
        drawingZone.Refresh();
      }

      if (e.Button == MouseButtons.Right)
      {
        mousePosition.X = e.X;
        mousePosition.Y = e.Y;
      }
    }

    private void drawingZone_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        Node firstEdge = getNearestNode(mousePosition);
        Node targetEdge = getNearestNode(e.Location);

        if (edgeNotFound(firstEdge) || edgeNotFound(targetEdge)) return;

        firstEdge.Neighbours.Add(targetEdge);
        targetEdge.Neighbours.Add(firstEdge);
        drawingKit.draw(graph.nodes);
        drawingZone.Refresh();
      }
    }

    private Node getNearestNode(Point position)
    {
      foreach (Node node in graph.nodes)
      {
        if (distance(position, node.Position) < drawingKit.Radius) return node;
      }

      return null;
    }

    private bool edgeNotFound(Node node)
    {
      return node == null ? true : false;
    }

    private bool checkColision(Point mousePosition)
    {
      if (mousePosition.X < 30 ||
         mousePosition.X > 470 ||
         mousePosition.Y < 30 ||
         mousePosition.Y > 470
        ) return false;

      foreach (Node node in graph.nodes)
      {
        if (distance(mousePosition, node.Position) < drawingKit.Radius * 2.5) return false;
      }

      return true;
    }

    private int distance(Point p1, Point p2)
    {
      return (int)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + (int)Math.Pow(p2.Y - p1.Y, 2));
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      drawingKit.clear();
      graph.nodes.Clear();
      Node.resetIdCounter();
      drawingZone.Refresh();
    }
  }
}
