namespace Datastructures.BinarySearchTree
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public T Data { get; set; }

        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }

        public TreeNode(T data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }

    }
}
