using System.Collections.Generic;

namespace CodeInterview.DataStructures
{
    public class Graph
    {
        public GraphNode Root { get; set; }
    }

    public class GraphNode
    {
        public int Value { get; set; }

        public List<GraphNode> Nodes { get; set; }
    }
}