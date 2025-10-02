using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class SingleLinkedList<T>
    {
        public T Data { get; }
        public SingleLinkedList<T>? Next { get; set; }

        public SingleLinkedList(T data, SingleLinkedList<T> next) {
            this.Data = data;
            this.Next = next;
        }

        public SingleLinkedList(T data) {
            this.Data = data;
        }
    }
}
