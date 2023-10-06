﻿namespace Datastructures.Datastructures
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T data)
        {
            this.Data = data;
            this.Next = null;
        }

        public T Data { get; set; }

        public LinkedListNode<T> Next { get; set; } 
    }
}