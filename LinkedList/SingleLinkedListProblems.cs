



namespace DSA.LinkedList
{
    public class SingleLinkedListProblems<T>
    {

        public static SingleLinkedList<T> convertArraytolinkedList(T[] ts)
        {
            SingleLinkedList<T> head = null;
            SingleLinkedList<T> current = null;

            for (int i = 0; i < ts.Length; i++)
            {
                var node = new SingleLinkedList<T>(ts[i]);

                if (head == null)
                {
                    current = node;
                    head = current;

                }
                else
                {
                    current.Next = node;
                    current = current.Next;
                }
            }
            
            return head;
        }

        public static SingleLinkedList<T>? removeHead(SingleLinkedList<T> node)
        {
            if (node == null || node.Next == null) return null;
            var prev = node;
            node = node.Next;
            prev.Next = null;
            return node;
        }

        public static SingleLinkedList<T> removeTail(SingleLinkedList<T> head)
        {
            if (head == null || head.Next == null) return null;

            var node = head;
            while (node.Next.Next != null) { 
                node = node.Next;
            }

            node.Next = null;

            return head;
        }

        public static SingleLinkedList<T> removeKthElement(SingleLinkedList<T> head, int k)
        {
            if (head == null) return null;

            if (k == 1) return removeHead(head);
            else
            {
                int count = 0;
                var temp = head;
                SingleLinkedList<T> prev = null;
                while (temp!= null) 
                {
                    count ++;
                    if(count == k)
                    {
                        prev.Next = prev.Next.Next;
                        break;
                    }
                    prev = temp;
                    temp = temp.Next;
                }
            }
            return head;
        }

        public static SingleLinkedList<T> removeByValue(SingleLinkedList<T> head, T value)
        {
            if (head == null) return null;

            if (areEqual(head.Data,value))return removeHead(head);

            else
            {
                var temp = head;
                SingleLinkedList<T> prev = null;
                while (temp!= null) 
                {
                    if(areEqual(temp.Data, value))
                    {
                        prev.Next = prev.Next.Next;
                        break;
                    }
                    prev = temp;
                    temp = temp.Next;
                }
            }
            return head;
        }

        public static bool areEqual(T? data, T? value)
        {
            return EqualityComparer<T>.Default.Equals(data,value);
        }

        public static void printLL(SingleLinkedList<T>? node)
        {
            Console.WriteLine("Linked list");
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
            Console.WriteLine("---------------");
            Console.WriteLine();
        }

        internal static SingleLinkedList<T> insertValueHead(SingleLinkedList<T> head, T v)
        {
            return new SingleLinkedList<T>(v,head);
        }

        internal static SingleLinkedList<T> insertValueTail(SingleLinkedList<T> head, T v)
        {
            var newNode = new SingleLinkedList<T>(v);
            var newHead = head;

            if (newHead == null) return newNode;


            while(head.Next != null)
            {
                head = head.Next;
            }

            head.Next = newNode;
            return newHead;
        }

        internal static SingleLinkedList<T> insertValueKthPosition(SingleLinkedList<T> head, int k , T value)
        {
            if(head == null)
            {
                if (k == 1)
                {
                    return insertValueHead(head, value);
                }
                else return null;
            }
            if(k == 1) return insertValueHead(head,value);

            var newNode = new SingleLinkedList<T>(value);
            var newHead = head;
            int count = 0;
            while (head != null)
            {
                count++;
                if (count == k-1)
                {
                    newNode.Next = head.Next;
                    head.Next = newNode;
                    break;
                }
                head = head.Next;
            }
            
            return newHead;
        }

        internal static SingleLinkedList<T> insertBeforeValue(SingleLinkedList<T> head, T beforeValue , T newValue)
        {
           if(head == null)
            {
                return null;
            }

            if (areEqual(head.Data, beforeValue))
            {
                return insertValueHead(head, newValue);
            }
            
            var newNode = new SingleLinkedList<T>(newValue);
            var newHead = head;

            while(head.Next != null)
            {
                if(areEqual(head.Next.Data,beforeValue))
                {
                    newNode.Next = head.Next;
                    head.Next = newNode;
                    break;
                }
                head = head.Next;
            }

            return newHead;
        }
        internal static SingleLinkedList<T>? ReversLL(SingleLinkedList<T> head)
        {
           if(head == null || head.Next == null)
            {
                return head;
            }
            var curr = head;
            SingleLinkedList<T>? prev = null;

            while (curr != null) 
            {
                var temp = prev;
                prev = curr;
                curr = curr.Next;
                prev.Next = temp;
            }

            return prev;
        }
        internal static SingleLinkedList<T>? ReversLLRecurtion(SingleLinkedList<T> head)
        {
           if(head == null || head.Next == null)
            {
                return head;
            }

            var newNode = ReversLLRecurtion(head.Next);

            var front = head.Next;
            front.Next = head;
            head.Next = null;
            return newNode;
        }
    }
}
