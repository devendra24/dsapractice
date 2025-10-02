using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    internal class DoubleLinkedList<T>
    {
        public T Data { get; }

        public DoubleLinkedList<T>? Prev { get; set; }
        public DoubleLinkedList<T>? Next { get; set; }

        public DoubleLinkedList(T data)
        {
            Data = data;
        }

        public DoubleLinkedList(T data, DoubleLinkedList<T> prev, DoubleLinkedList<T> next)
        {
            Data = data;
            Prev = prev;
            Next = next;
        }
    }
}
