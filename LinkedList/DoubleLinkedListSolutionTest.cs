

namespace DSA.LinkedList
{
    internal class DoubleLinkedListSolutionTest
    {
        public void Test()
        {
            Console.WriteLine("are equal");
            Console.WriteLine(DoubleLinkedListProblems<int>.areEqual(8, 8));
            Console.WriteLine();

            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("converintng array to LL");
            var node = DoubleLinkedListProblems<int>.ConvertArraytoDoubleLinkedList(values);
            var curr = node;    
            DoubleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("removing head LL");
            node = DoubleLinkedListProblems<int>.RemoveHead(node);
            DoubleLinkedListProblems<int>.printLL(node);
            DoubleLinkedListProblems<int>.printLL(curr);


            Console.WriteLine("removing tail LL");
            node = DoubleLinkedListProblems<int>.RemoveTail(node);
            DoubleLinkedListProblems<int>.printLL(node);
            DoubleLinkedListProblems<int>.printLL(curr);

            Console.WriteLine("removing Kth(3) element LL");
            node = DoubleLinkedListProblems<int>.RemoveKthElement(node, 3);
            DoubleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("removing Kth(8) element LL");
            node = DoubleLinkedListProblems<int>.RemoveKthElement(node, 8);
            DoubleLinkedListProblems<int>.printLL(node);

            //Console.WriteLine("removing by value 8 LL");
            //node = DoubleLinkedListProblems<int>.removeByValue(node, 8);
            //DoubleLinkedListProblems<int>.printLL(node);

            //Console.WriteLine("removing by value 4 LL");
            //node = DoubleLinkedListProblems<int>.removeByValue(node, 4);
            //DoubleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("intserting to head LL");
            node = DoubleLinkedListProblems<int>.InsertValueHead(node, 4);
            DoubleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("intserting to trail LL");
            node = DoubleLinkedListProblems<int>.InsertValueTail(node, 9);
            DoubleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("intserting at kth 4th , 9 LL");
            curr = DoubleLinkedListProblems<int>.InsertValueKthPosition(node, 4, 9);
            DoubleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("intserting at kth 10th , 12 LL");
            node = DoubleLinkedListProblems<int>.InsertValueKthPosition(node, 10, 12);
            DoubleLinkedListProblems<int>.printLL(node);


            Console.WriteLine("Reverse DDL");
            node = DoubleLinkedListProblems<int>.RevervseDLL(node);
            DoubleLinkedListProblems<int>.printLL(node);


            Console.WriteLine("Reverse DDL");
            node = DoubleLinkedListProblems<int>.RevervseDLL(node);
            DoubleLinkedListProblems<int>.printLL(node);


            //Console.WriteLine("intserting before value 7 ,11 LL");
            //node = DoubleLinkedListProblems<int>.insertBeforeValue(node, 7, 11);
            //DoubleLinkedListProblems<int>.printLL(node);


        }
    }
}
