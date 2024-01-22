using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs_project
{
  internal class DrawingKit
  {
    public int Radius { get; }
    private Graphics graphics;
    private Pen blackPen;
    private Pen greenPen;
    private Brush nodeBrush;
    private Brush idBrush;
    private Size ellipseSize;
    private Font idFont;

    public DrawingKit(PictureBox picture)
    {
      Radius = 20;
      initGraphics(picture.Image);
      initPens();
      initBrushes();
      initEllipseSize();
      initIdFont();
    }

    public void draw(Graph graph)
    {
      graphics.Clear(Color.White);
      drawConnections(graph.nodes);
      drawNodes(graph.nodes);
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
      nodeBrush = new SolidBrush(Color.White);
      idBrush = new SolidBrush(Color.Black);
    }

    private void initEllipseSize()
    {
      ellipseSize = new Size(Radius * 2, Radius * 2);
    }

    private void initIdFont()
    {
      idFont = new Font("Microsoft Sans Serif", Radius / (float)1.25);
    }

    private void drawConnections(List<Node> nodes)
    {
      foreach (Node node in nodes)
      {
        foreach (Node neighbour in node.Neighbours)
        {
          graphics.DrawLine(blackPen, node.Position, neighbour.Position);
        }
      }
    }

    private void drawNodes(List<Node> nodes)
    {
      foreach (Node node in nodes)
      {
        Rectangle rectangle = new Rectangle(
          node.getMiddlePoint(Radius),
          ellipseSize
          );

        graphics.FillEllipse(nodeBrush, rectangle);
        graphics.DrawEllipse(blackPen, rectangle);

        graphics.DrawString(
          node.NodeID.ToString(),
          idFont,
          idBrush,
          node.getMiddlePoint(Radius / 2)
          );
      }
    }

    public void clear()
    {
      graphics.Clear(Color.White);
    }
  }
}
