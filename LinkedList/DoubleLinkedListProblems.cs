







namespace DSA.LinkedList
{
    internal class DoubleLinkedListProblems<T>
    {
        internal static bool areEqual(T v1, T v2)
        {
            return EqualityComparer<T>.Default.Equals(v1, v2);
        }

        internal static void CheckNodelinked(DoubleLinkedList<T> node)
        {
            Console.WriteLine($"Checking for Node {node.Data}");
            Console.WriteLine($"Left Node = Null:{node.Prev == null}");
            Console.WriteLine($"Right Node = Null:{node.Next == null}");
        }

        public static void printLL(DoubleLinkedList<T> node)
        {
            Console.WriteLine("Double Linked list");
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
            Console.WriteLine("---------------");
            Console.WriteLine();
        }

        internal static DoubleLinkedList<T>? ConvertArraytoDoubleLinkedList(T[] values)
        {
            DoubleLinkedList<T>? head = null;
            var iterator = head;

            for(int i = 0; i< values.Length; i++)
            {
                var node = new DoubleLinkedList<T>(values[i]);
                if (head == null)
                {
                    iterator = node; 
                    head = iterator;
                }
                else
                {
                    node.Prev = iterator;
                    iterator.Next = node;
                    iterator = iterator.Next;
                }
            }

            return head;
        }

        internal static DoubleLinkedList<T>? RemoveHead(DoubleLinkedList<T> head)
        {
            if (head == null || head.Next == null) return null;
            var prev = head;
            head = head.Next;
            head.Prev = null;
            prev.Next = null;
            return head;
        }

        internal static DoubleLinkedList<T>? RemoveTail(DoubleLinkedList<T> head)
        {
            if (head == null || head.Next == null) return null;

            var curr = head;

            while (curr.Next != null)
            {
                curr = curr.Next;
            }

            var prev = curr.Prev;
            curr.Prev = null;
            prev.Next = null;

            CheckNodelinked(curr);

            return head;

        }

        internal static DoubleLinkedList<T> RemoveKthElement(DoubleLinkedList<T>? head, int k)
        {
            if (head == null || head.Next == null) return null;

            var current = head;
            int count = 0;

            while (current != null)
            {
                count++;
                if (count == k)
                {
                    var prev = current.Prev;
                    var next = current.Next;

                    prev.Next = next;
                    if(next!=null)
                        next.Prev = prev;


                    current.Next = null;
                    current.Prev = null;
                    CheckNodelinked(current);
                    break;
                }

                current = current.Next;
            }


            return head;
        }

        internal static DoubleLinkedList<T> InsertValueHead(DoubleLinkedList<T> node, T v)
        {
            var newnode = new DoubleLinkedList<T>(v, null, node);
            node.Prev = newnode;
            CheckNodelinked(node);
            return newnode;
            
        }

        internal static DoubleLinkedList<T> InsertValueTail(DoubleLinkedList<T> head, T v)
        {
            var newNode = new DoubleLinkedList<T>(v);
            if (head == null) return newNode;
            var curr = head;

            while (curr.Next != null) 
            {
                curr = curr.Next;
            }

            curr.Next = newNode;
            newNode.Prev = curr;
            CheckNodelinked(curr);
            return head;
        }

        internal static DoubleLinkedList<T> InsertValueKthPosition(DoubleLinkedList<T> head, int k, T data)
        {
            var newNode = new DoubleLinkedList<T>(data);
            if (head == null)
            {
                if (k == 1) return newNode;
                return null;
            }
            if (k == 1)
            {
                newNode.Next = head;
                head.Prev = newNode;
                return newNode;
            }

            var curr = head;
            int counter = 0;
            while (curr.Next != null) 
            { 
                counter ++;
                if (counter == k - 1) 
                {
                    newNode.Next = curr.Next;
                    newNode.Prev = curr;

                    curr.Next.Prev = newNode;
                    curr.Next = newNode;

                    break;
                }

                curr = curr.Next;
            }

            return head;
        }

        internal static DoubleLinkedList<T>? RevervseDLL(DoubleLinkedList<T> head)
        {
            if(head == null || head.Next == null)
            {
                return head;
            }

            var curr = head;
            DoubleLinkedList<T>? prev = null;

            while (curr != null) { 
                prev = curr.Prev;

                curr.Prev = curr.Next;
                curr.Next = prev;

                curr=curr.Prev;
            }

            return prev.Prev;

        }
    }
}
