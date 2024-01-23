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
    public List<KeyValuePair<Node, Node>> Steps { get; }

    protected Algorithm(Graph graph)
    {
      this.graph = graph;
      Steps = new List<KeyValuePair<Node, Node>>();
    }

    public abstract void search();
  }
}
