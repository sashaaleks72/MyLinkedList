using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        public MyLinkedList()
        {
        }

        public MyLinkedList(IList<T> someList)
        {
            for (int i = 0; i < someList.Count; i++)
            {
                AddLast(someList[i]);
            }
        }

        public MyLinkedListNode<T> First { get; set; }

        public MyLinkedListNode<T> Last { get; set; }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                int i = 0;
                MyLinkedListNode<T> nodeToIterate = First;

                while (i != index)
                {
                    nodeToIterate = nodeToIterate.Next;
                    i++;
                }

                return nodeToIterate.Value;
            }
        }

        public void AddAfter(MyLinkedListNode<T> node, MyLinkedListNode<T> newNode)
        {
            newNode.Previous = node;
            newNode.Next = node.Next;
            node.Next = newNode;

            if (node == Last)
            {
                Last = newNode;
            }

            Count++;
        }

        public void AddAfter(MyLinkedListNode<T> node, T value)
        {
            var newNode = new MyLinkedListNode<T>(value);
            AddAfter(node, newNode);
        }

        public void AddBefore(MyLinkedListNode<T> node, MyLinkedListNode<T> newNode)
        {
            newNode.Previous = node.Previous;
            newNode.Next = node;
            node.Previous = newNode;

            if (node == First)
            {
                First = newNode;
            }

            Count++;
        }

        public void AddBefore(MyLinkedListNode<T> node, T value)
        {
            var newNode = new MyLinkedListNode<T>(value);
            AddBefore(node, newNode);
        }

        public void AddFirst(MyLinkedListNode<T> node)
        {
            if (First == null)
            {
                First = node;
                Last = node;
            }
            else
            {
                node.Next = First;
                First = node;
                node = node.Next;
                node.Previous = First;
            }

            Count++;
        }

        public void AddFirst(T value)
        {
            var node = new MyLinkedListNode<T>(value);
            AddFirst(node);
        }

        public void AddLast(MyLinkedListNode<T> node)
        {
            if (Last == null)
            {
                First = node;
                Last = node;
            }
            else
            {
                node.Previous = Last;
                Last = node;
                node = node.Previous;
                node.Next = Last;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            var node = new MyLinkedListNode<T>(value);
            AddLast(node);
        }

        public void RemoveFirst()
        {
            First = First.Next;
            First.Previous = null;

            Count--;
        }

        public void RemoveLast()
        {
            Last = Last.Previous;
            Last.Next = null;

            Count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            MyLinkedListNode<T> nodeToIterate = First;

            while (nodeToIterate != null)
            {
                yield return nodeToIterate;
                nodeToIterate = nodeToIterate.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            MyLinkedListNode<T> nodeToIterate = First;

            while (nodeToIterate != null)
            {
                yield return nodeToIterate.Value;
                nodeToIterate = nodeToIterate.Next;
            }
        }
    }
}
