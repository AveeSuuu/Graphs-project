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
        mousePosition.X = e.X; mousePosition.Y = e.Y;

        if (graphOperations.getNearestNode(mousePosition) == null)
        {
          graphOperations.addNode(mousePosition);
        }
      }

      if (e.Button == MouseButtons.Right)
      {
        Node node = graphOperations.getNearestNode(e.Location);
        if (node == null) return;

        graphOperations.markNodeAsStart(node);
      }
    }

    private void drawingZone_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Node firstNode = graphOperations.getNearestNode(mousePosition);
        Node secondNode = graphOperations.getNearestNode(e.Location);
        graphOperations.connect(firstNode, secondNode);
      }

      drawingKit.draw(graph);
      drawingZone.Refresh();
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      drawingKit.clear();
      graph.Nodes.Clear();
      Node.resetIdCounter();
      drawingZone.Refresh();
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
      if (!BFSradioButton.Checked && !DFSradioButton.Checked)
      {
        MessageBox.Show("No algorithm selected!");
        return;
      }

      Algorithm algorithm = GetAlgorithm();

      drawingKit.drawAlgorithm(algorithm.Steps, graph);
    }

    internal Algorithm GetAlgorithm()
    {
      if (BFSradioButton.Checked) return new BFS(graph);
      if (DFSradioButton.Checked) return new DFS(graph);
      return null;
    }
  }
}