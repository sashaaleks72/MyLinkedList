#nullable enable

namespace LinkedList
{
    public class MyLinkedListNode<T>
    {
        public MyLinkedListNode(T value)
        {
            Value = value;
        }

        public MyLinkedListNode<T>? Next { get; set; }

        public MyLinkedListNode<T>? Previous { get; set; }

        public T Value { get; set; }
    }
}
