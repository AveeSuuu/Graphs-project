using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs_project
{
  public partial class GraphsMainForm : Form
  {
    Bitmap bitmap;
    Graphics g;
    Pen verticesPen;
    Pen edgePen;

    public GraphsMainForm()
    {
      InitializeComponent();
      g = Graphics.FromImage(bitmap);
      g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
      g.Clear(Color.White);
      verticesPen = new Pen(Color.Black, 3);
    }
  }
}
