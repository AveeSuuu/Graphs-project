using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
    private Brush whiteBrush;
    private Brush greenBrush;
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
      drawConnections(graph.Nodes);
      drawNodes(graph.Nodes);
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
      greenPen = new Pen(Color.LightGreen, 3);
    }

    private void initBrushes()
    {
      whiteBrush = new SolidBrush(Color.White);
      greenBrush = new SolidBrush(Color.LightGreen);
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

        if (node.StartFlag)
        {
          graphics.FillEllipse(greenBrush, rectangle);
        }
        else
        {
          graphics.FillEllipse(whiteBrush, rectangle);
        }

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

    public void drawAlgorithm(List<KeyValuePair<Node, Node>> sequence, Graph graph, PictureBox picture)
    {
      List<KeyValuePair<Node, Node>> steps = new List<KeyValuePair<Node, Node>>();

      foreach (KeyValuePair<Node, Node> pair in sequence)
      {
        steps.Add(pair);
        drawConnections(graph.Nodes);
        drawAlgorithmSequence(steps);
        drawNodes(graph.Nodes);
        Thread.Sleep(250);
        picture.Refresh();
      }
    }

    private void drawAlgorithmSequence(List<KeyValuePair<Node, Node>> steps)
    {
      foreach(KeyValuePair<Node, Node> pair in steps)
      {
        graphics.DrawLine(greenPen, pair.Key.Position, pair.Value.Position);
      }
    }
  }
}
