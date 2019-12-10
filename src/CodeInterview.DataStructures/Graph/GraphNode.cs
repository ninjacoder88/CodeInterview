using System.Collections.Generic;

namespace CodeInterview.DataStructures.Graph
{
    public class GraphNode<T>
    {
        public T Value { get; set; }

        public List<GraphNode<T>> Nodes { get; set; }
    }
}