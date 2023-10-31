using System.Numerics;

namespace Datastructures.BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private TreeNode<T> root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(T data)
        {
            this.root = Insert(this.root, data);
        }

        public bool Search(T data)
        {
            return Search(root, data);
        }

        public void Delete(T data)
        {
            this.root = Delete(this.root, data);
        }

        public void InOrderPrint()
        {
            InOrder(this.root);
        }

        public void PreOrderPrint()
        {
            PreOrder(this.root);
        }

        public void PostOrderPrint()
        {
            PostOrder(this.root);
        }

        public T FindMin()
        {
            if (this.root == null)
            {
                throw new InvalidOperationException("The tree is empty!");
            }

            return FindMin(this.root);
        }

        public T FindMax()
        {
            if (this.root == null)
            {
                throw new InvalidOperationException("The tree is empty!");
            }

            return FindMax(this.root);
        }

        public void BFS()
        {
            if (this.root == null)
            {
                return;
            }

            var queue = new Queue<TreeNode<T>>();
            queue.Enqueue(this.root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                Console.Write(node.Data + " ");

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }

        public void InOrderDFS()
        {
            if (this.root == null)
            {
                return;
            }

            var stack = new Stack<TreeNode<T>>();
            var current = this.root;
            while (current != null || stack.Count > 0)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                else 
                {
                    current = stack.Pop();
                    Console.Write(current.Data + " ");
                    current = current.Right;
                }
            }
        }

        public void PreOrderDFS()
        {
            if (this.root == null)
            {
                return;
            }

            var stack = new Stack<TreeNode<T>>();
            stack.Push(this.root);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                Console.Write(current.Data + " ");
                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
            }
        }

        public void PostOrderDFS()
        {
            if (root == null)
                return;

            var stack = new Stack<TreeNode<T>>();
            var current = root;
            TreeNode<T> lastVisited = null;

            while (current != null || stack.Count > 0)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.Left; 
                }
                else
                {
                    var peek = stack.Peek();
                    if (peek.Right != null && peek.Right != lastVisited)
                    {
                        current = peek.Right;
                    }
                    else
                    {
                        current = stack.Pop();
                        Console.Write(current.Data + " ");
                        lastVisited = current;
                        current = null;
                    }
                }
            }
        }

        private TreeNode<T> Insert(TreeNode<T> node, T data)
        {
            if (node == null) 
            {
                return new TreeNode<T>(data);
            }

            if (data.CompareTo(node.Data) < 0)
            {
                node.Left = Insert(node.Left, data);
            }
            else if (data.CompareTo(node.Data) > 0)
            {
                node.Right = Insert(node.Right, data);
            }

            return node;
        }

        private bool Search(TreeNode<T> node, T data)
        {
            if (node == null) 
            {
                return false;
            }

            if (data.CompareTo(node.Data) == 0)
            {
                return true;
            }
            else if (data.CompareTo(node.Data) < 0)
            {
                return Search(node.Left, data);
            }

            return Search(node.Right, data);        
        }

        private TreeNode<T> Delete(TreeNode<T> node, T data)
        {
            if (node == null)
            {
                return node;
            }

            if (data.CompareTo(node.Data) < 0)
            {
                node.Left = Delete(node.Left, data);
            }
            else if (data.CompareTo(node.Data) > 0)
            {
                node.Right = Delete(node.Right, data);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                node.Data = MinValue(node.Right);
                node.Right = Delete(node.Right, node.Data);
            }

            return node;
        }

        private T MinValue(TreeNode<T> node)
        {
            T minValue = node.Data;
            while (node.Left != null)
            {
                minValue = node.Left.Data;
                node = node.Left;
            }

            return minValue;
        }

        private void InOrder(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.Left);
            Console.Write(node.Data + " ");
            InOrder(node.Right);
        }

        private void PreOrder(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.Data + " ");
            InOrder(node.Left);
            InOrder(node.Right);
        }

        private void PostOrder(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.Left);
            InOrder(node.Right);
            Console.Write(node.Data + " ");
        }

        private T FindMin(TreeNode<T> node)
        {
            if(node.Left == null) 
            {
                return node.Data;
            }

            return FindMin(node.Left);
        }

        private T FindMax(TreeNode<T> node)
        {
            if (node.Right == null)
            {
                return node.Data;
            }

            return FindMax(node.Right);
        }
    }
}
