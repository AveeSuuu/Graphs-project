using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_project
{
  internal class DrawingKit
  {
    public Graphics graphics;
    public Pen blackPen;
    public Pen greenPen;
    public Brush edgesBrush;
    public Brush idBrush;

    public DrawingKit(Bitmap bitmap)
    {
      initGraphics(bitmap);
      initPens();
      initBrushes();
    }

    private void initGraphics(Bitmap bitmap)
    {
      graphics = Graphics.FromImage(bitmap);
      graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
      graphics.Clear(Color.White);
    }

    private void initPens()
    {
      blackPen = new Pen(Color.Black, 3);
      greenPen = new Pen(Color.Green, 3);
    }

    private void initBrushes()
    {
      edgesBrush = new SolidBrush(Color.White);
      idBrush = new SolidBrush(Color.Black);
    }
  }
}
