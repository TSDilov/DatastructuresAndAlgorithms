namespace Datastructures.Models
{
    public class Node
    {

        public Node(int row, int col, int distance)
        {
            Row = row;
            Col = col;
            Distance = distance;
        }

        public int Row { get; }
        public int Col { get; }
        public int Distance { get; }
    }
}
