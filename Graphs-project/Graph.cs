using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs_project
{
  internal class Graph
  {
    private Bitmap bitmap;
    public List<Node> nodes { get; }

    public Graph(PictureBox picture)
    {
      bitmap = new Bitmap(500, 500);
      nodes = new List<Node>();
      picture.Image = bitmap;
    }
  }
}
