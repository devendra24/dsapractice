using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    internal class DoubleLinkedList<T>(T data)
    {
        public T Data { get; } = data;

        public DoubleLinkedList<T>? Prev { get; set; }
        public DoubleLinkedList<T>? Next { get; set; }
    }
}
