using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class SingleLinkedListSolutionTest
    {

        //To do Test Using Xunit
        public void Test()
        {
            Console.WriteLine("are equal");
            Console.WriteLine(SingleLinkedListProblems<int>.areEqual(8, 8));
            Console.WriteLine();

            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("converintng array to LL");
            var node = SingleLinkedListProblems<int>.convertArraytolinkedList(values);
            SingleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("removing head LL");
            node = SingleLinkedListProblems<int>.removeHead(node);
            SingleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("removing tail LL");
            node = SingleLinkedListProblems<int>.removeTail(node);
            SingleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("removing Kth(2) element LL");
            node = SingleLinkedListProblems<int>.removeKthElement(node,2);
            SingleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("removing Kth(8) element LL");
            node = SingleLinkedListProblems<int>.removeKthElement(node,8);
            SingleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("removing by value 8 LL");
            node = SingleLinkedListProblems<int>.removeByValue(node, 8);
            SingleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("removing by value 4 LL");
            node = SingleLinkedListProblems<int>.removeByValue(node, 4);
            SingleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("intserting to head LL");
            node = SingleLinkedListProblems<int>.insertValueHead(node, 4);
            SingleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("intserting to trail LL");
            node = SingleLinkedListProblems<int>.insertValueTail(node, 4);
            SingleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("intserting at kth 4th , 9 LL");
            node = SingleLinkedListProblems<int>.insertValueKthPosition(node, 4,9);
            SingleLinkedListProblems<int>.printLL(node);

            Console.WriteLine("intserting at kth 10th , 12 LL");
            node = SingleLinkedListProblems<int>.insertValueKthPosition(node, 10,12);
            SingleLinkedListProblems<int>.printLL(node);


            Console.WriteLine("intserting before value 7 ,11 LL");
            node = SingleLinkedListProblems<int>.insertBeforeValue(node, 7,11);
            SingleLinkedListProblems<int>.printLL(node);

            
        }
    }
}
