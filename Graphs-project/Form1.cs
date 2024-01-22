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
    GraphOperations graphOperations;
    DrawingKit drawingKit;
    Point mousePosition;

    public GraphsMainForm()
    {
      InitializeComponent();
      graph = new Graph(drawingZone);
      drawingKit = new DrawingKit(drawingZone);
      graphOperations = new GraphOperations(graph, drawingKit.Radius);
      mousePosition = new Point();
    }

    private void drawingZone_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        graphOperations.addNode(e.Location);
        drawingKit.draw(graph);
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
        Node firstEdge = graphOperations.getNearestNode(mousePosition);
        Node targetEdge = graphOperations.getNearestNode(e.Location);

        graphOperations.connect(firstEdge, targetEdge);

        drawingKit.draw(graph);
        drawingZone.Refresh();
      }
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
