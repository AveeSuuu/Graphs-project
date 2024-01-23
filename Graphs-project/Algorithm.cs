using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_project
{
  abstract class Algorithm
  {
    protected Graph graph;
    public Queue<Node> Steps { get; }

    protected Algorithm(Graph graph)
    {
      this.graph = graph;
      Steps = new Queue<Node>();
    }

    public abstract void search();
  }
}
