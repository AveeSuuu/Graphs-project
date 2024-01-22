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
    public Size ellipseSize;
    public readonly int radius = 20;
    public Font idFont;

    public DrawingKit(Image image)
    {
      initGraphics(image);
      initPens();
      initBrushes();
      initEllipseSize();
      initIdFont();
    }

    private void initGraphics(Image image)
    {
      graphics = Graphics.FromImage(image);
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

    private void initEllipseSize()
    {
      ellipseSize = new Size(radius * 2, radius * 2);
    }

    private void initIdFont()
    {
      idFont = new Font("Microsoft Sans Serif", radius / (float)1.25);
    }

    public void draw(List<Node> edges)
    {
      graphics.Clear(Color.White);
      drawConnections(edges); //a to jest krawędź
      drawEdges(edges); //to jest kurwa połaczenie NODE Z ANGIELSKIEGo
    }
    //DFS(start, target, new Hashset<Edges>)

    private void drawConnections(List<Node> edges)
    {
      foreach (Node edge in edges)
      {
        foreach (Node neigbour in edge.Neighbours)
        {
          graphics.DrawLine(blackPen, edge.Position, neigbour.Position);
        }
      }
    }

    private void drawEdges(List<Node> edges)
    {
      foreach (Node edge in edges)
      {
        Rectangle rectangle = new Rectangle(
          edge.getMiddlePoint(radius),
          ellipseSize
          );

        graphics.FillEllipse(edgesBrush, rectangle);
        graphics.DrawEllipse(blackPen, rectangle);

        graphics.DrawString(
          edge.EdgeID.ToString(),
          idFont,
          idBrush,
          edge.getMiddlePoint(radius / 2)
          );
      }
    }

    public void clear()
    {
      graphics.Clear(Color.White);
    }
  }
}
