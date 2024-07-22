using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace GraphNodeApp;

public class GraphNode
{
    public string Name { get; private set;}
    public List<GraphNode> AdjList { get; private set; }

    public GraphNode(string name)
    {
        Name = name;
        AdjList = new List<GraphNode>();
    }

    public void AddEdge(GraphNode to)
    {
        AdjList.Add(to);
    }
}