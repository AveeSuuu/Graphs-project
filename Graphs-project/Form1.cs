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

    public GraphsMainForm()
    {
      InitializeComponent();
      bitmap = new Bitmap(500, 500);
      drawingZone.Image = bitmap;
      drawingKit = new DrawingKit(drawingZone.Image);
      edges = new List<Edge>();
    }

    private void drawingZone_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        edges.Add(new Edge(e.X, e.Y));
        drawingKit.draw(edges);
        drawingZone.Refresh();
      }
    }

    private void drawingZone_MouseUp(object sender, MouseEventArgs e)
    {

    }
  }
}
