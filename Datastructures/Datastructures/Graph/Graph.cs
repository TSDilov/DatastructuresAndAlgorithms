using System.Net.Http.Headers;

namespace Datastructures.Graph
{
    public class Graph<TVertex, TEdge> where TEdge : IConvertible
    {
        private readonly Dictionary<TVertex, List<Edge<TVertex, TEdge>>> adjacencyLists;

        public Graph()
        {
            this.adjacencyLists = new Dictionary<TVertex, List<Edge<TVertex, TEdge>>>();
        }

        public void AddVertex(TVertex vertex)
        {
            if (!this.adjacencyLists.ContainsKey(vertex))
            {
                this.adjacencyLists.Add(vertex, new List<Edge<TVertex, TEdge>>());
            }
        }

        public void AddEdge(TVertex source, TVertex destination, TEdge edgeWeight)
        {
            if (!this.adjacencyLists.ContainsKey(source))
            {
                throw new ArgumentException($"Vertex '{source}' does not exist.");
            }

            if (!this.adjacencyLists.ContainsKey(destination))
            {
                throw new ArgumentException($"Vertex '{destination}' does not exist.");
            }

            this.adjacencyLists[source].Add(new Edge<TVertex, TEdge>(destination, edgeWeight));
        }

        public IEnumerable<TVertex> GetVertices()
        {
            return this.adjacencyLists.Keys.ToList();
        }

        public IEnumerable<Edge<TVertex, TEdge>> GetEdges() 
        {
            var edges = new List<Edge<TVertex, TEdge>>();
            foreach (var vertex in this.adjacencyLists.Keys)
            {
                foreach (var edge in this.adjacencyLists[vertex])
                {
                    edges.Add(edge);
                }
            }

            return edges;
        }

        public bool HasVertex(TVertex vertex)
        {
            return this.adjacencyLists.ContainsKey(vertex);
        }

        public bool HasEdge(TVertex source, TVertex destination) 
        {
            if (!adjacencyLists.ContainsKey(source) || !adjacencyLists.ContainsKey(destination))
            {
                return false;
            }

            return this.adjacencyLists[source].Any(edge => edge.Destination.Equals(destination));
        }

        public void RemoveVertex(TVertex vertex)
        {
            if (!adjacencyLists.ContainsKey(vertex))
            {
                throw new ArgumentException($"Vertex '{vertex}' does not exist.");
            }

            this.adjacencyLists.Remove(vertex);

            foreach (var remainingVertex in this.adjacencyLists.Keys)
            {
                this.adjacencyLists[remainingVertex].RemoveAll(edge => edge.Destination.Equals(vertex));
            }
        }

        public void RemoveEdge(TVertex source, TVertex destination)
        {
            if (!adjacencyLists.ContainsKey(source) || !adjacencyLists.ContainsKey(destination))
            {
                throw new ArgumentException("Either source or destination vertex does not exist.");
            }

            this.adjacencyLists[source].RemoveAll(edge => edge.Destination.Equals(destination));
        }

        public void PrintGraph()
        {
            foreach (var vertex in this.GetVertices())
            {
                Console.Write($"Vertex {vertex}: ");
                foreach (var edge in this.adjacencyLists[vertex])
                {
                    Console.Write($"({edge.Destination}, {edge.Weight}) ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public Dictionary<TVertex, TEdge> BellmanFordAlgorithm(TVertex source)
        {
            var distances = new Dictionary<TVertex, TEdge>();
            var predecessors = new Dictionary<TVertex, TVertex>();
            var infinityFlag = GetInfinityFlag();

            foreach (var vertex in this.GetVertices())
            {
                distances[vertex] = (vertex.Equals(source)) ? default : infinityFlag;
                predecessors[vertex] = default(TVertex);
            }

            for (int i = 0; i < this.GetVertices().Count() - 1; ++i)
            {
                foreach (var vertex in this.GetVertices())
                {
                    foreach (var edge in this.adjacencyLists[vertex])
                    {
                        TEdge potentialDistance = Add(distances[vertex], edge.Weight);

                        if (Comparer(potentialDistance, distances[edge.Destination]) < 0)
                        {
                            distances[edge.Destination] = potentialDistance;
                            predecessors[edge.Destination] = vertex;
                        }
                    }
                }
            }

            foreach (var vertex in this.GetVertices())
            {
                foreach (var edge in this.adjacencyLists[vertex])
                {
                    TEdge potentialDistance = Add(distances[vertex], edge.Weight);

                    if (Comparer(potentialDistance, distances[edge.Destination]) < 0)
                    {
                        Console.WriteLine("Graph contains negative weight cycle");
                        return null;
                    }
                }
            }

            return distances;
        }

        private TEdge Add(TEdge a, TEdge b)
        {
            return (TEdge)((dynamic)a + b);
        }

        private int Comparer(TEdge a, TEdge b)
        {
            return Comparer<TEdge>.Default.Compare(a, b);
        }

        private TEdge GetInfinityFlag()
        {
            return (TEdge)Convert.ChangeType(1, typeof(TEdge));
        }
    }
}
