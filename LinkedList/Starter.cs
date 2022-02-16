using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Starter
    {
        public Starter(IList<int> integerList)
        {
            IntegerList = integerList;
            MyLinkedList = new MyLinkedList<int>(IntegerList);
        }

        public IList<int> IntegerList { get; set; }
        public MyLinkedList<int> MyLinkedList { get; set; }

        public void Run()
        {
            IntegerList.Add(1);
            IntegerList.Add(2);
            IntegerList.Add(3);
            IntegerList.Add(4);
            IntegerList.Add(10);
            IntegerList.Add(56);
            IntegerList.Add(76);
            IntegerList.Add(12);

            var myLinkedList = new MyLinkedList<int>(IntegerList);

            foreach (var item in myLinkedList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            myLinkedList.AddBefore(myLinkedList.First, 40);
            myLinkedList.AddAfter(myLinkedList.First, 23);
            myLinkedList.AddAfter(myLinkedList.Last, 9);

            foreach (var item in myLinkedList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            myLinkedList.AddLast(6);
            myLinkedList.AddLast(15);
            myLinkedList.AddLast(28);

            foreach (var item in myLinkedList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            myLinkedList.RemoveFirst();
            myLinkedList.RemoveLast();

            foreach (var item in myLinkedList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            for (int i = 0; i < myLinkedList.Count; i++)
            {
                Console.Write($"{myLinkedList[i]} ");
            }

            Console.WriteLine();
        }
    }
}
