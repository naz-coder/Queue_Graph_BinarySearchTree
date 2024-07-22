using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace GraphNodeApp;

public class Graph
{
    private List<GraphNode> nodes = new List<GraphNode>();

    /*Adds the constructor to the end or start of the list, the position doesn't matter in graph, it just need to add the constructor to a node(start or end node)*/
    public void AddNode(string name)
    {
        if(nodes.All(n => n.Name != name))
        nodes.Add(new GraphNode(name));
    }

    public GraphNode GetNodeByName(string name)
    {
       return nodes.FirstOrDefault(n => n.Name == name);
    }

    /*Add a directed edge between node with name = "from" and the node with name = "to"*/
    public void AddEdge(string from, string to)
    {
        GraphNode fromNode = GetNodeByName(from); 
        GraphNode toNode = GetNodeByName(to);

        if(fromNode != null && toNode != null)
            fromNode.AddEdge(toNode);
    }

    public int NodeCount()
    {
        return nodes.Count;
    }

    public int EdgeCount()
    {
        return nodes.Sum(node => node.AdjList.Count);
    }

    public List<string> BreadthFirstSearch(string startName)
    {
        var startNode = GetNodeByName(startName);
        if (startNode == null) return new List<string>();

        var visited = new List<string>();
        var queue = new Queue<GraphNode>();
        queue.Enqueue(startNode);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (!visited.Contains(node.Name))
            {
                visited.Add(node.Name);
                foreach (var neighbor in node.AdjList)
                {
                    if (!visited.Contains(neighbor.Name))
                        queue.Enqueue((neighbor));
                }
            }
        }
        return visited;
    }

    public bool CanTraverse(string from, string to)
    {
        var visited = BreadthFirstSearch(from);
        return visited.Contains(to);
    }
}