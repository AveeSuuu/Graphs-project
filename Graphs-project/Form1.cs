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
    Bitmap bitmap;
    DrawingKit drawingKit;
    List<Edge> edges;
    Point mousePosition;

    public GraphsMainForm()
    {
      InitializeComponent();
      bitmap = new Bitmap(500, 500);
      drawingZone.Image = bitmap;
      drawingKit = new DrawingKit(drawingZone.Image);
      edges = new List<Edge>();
      mousePosition = new Point();
    }

    private void drawingZone_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        if (!checkColision(e.Location)) return;

        edges.Add(new Edge(e.X, e.Y));
        drawingKit.draw(edges);
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
        Edge firstEdge = getNearestEdge(mousePosition);
        Edge targetEdge = getNearestEdge(e.Location);
        if (edgeNotFound(firstEdge) || edgeNotFound(targetEdge)) return;

        firstEdge.Neighbours.Add(targetEdge);
        targetEdge.Neighbours.Add(firstEdge);
        drawingKit.draw(edges);
        drawingZone.Refresh();
      }
    }

    private Edge getNearestEdge(Point position)
    {
      foreach (Edge edge in edges)
      {
        if (distance(position, edge.Position) < drawingKit.radius) return edge;
      }

      return null;
    }

    private bool edgeNotFound(Edge edge)
    {
      return edge == null ? true : false;
    }

    private bool checkColision(Point mousePosition)
    {
      if (mousePosition.X < 30 ||
         mousePosition.X > 470 ||
         mousePosition.Y < 30 ||
         mousePosition.Y > 470
        ) return false;

      foreach (Edge edge in edges)
      {
        if (distance(mousePosition, edge.Position) < drawingKit.radius * 2.5) return false;
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
      edges.Clear();
      Edge.resetIdCounter();
      drawingZone.Refresh();
    }
  }
}
