namespace Datastructures.Graph
{
    public class Edge<TVertex, TEdge>
    {
        public Edge(TVertex destination, TEdge weight)
        {
            this.Destination = destination;
            this.Weight = weight;
        }

        public TVertex Destination { get; private set; }

        public TEdge Weight { get; private set; }
    }
}
