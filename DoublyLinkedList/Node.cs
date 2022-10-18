namespace DoublyLinkedList
{
    public class Node<T>
    {
        public T Data { get; set; } // зачем именно нужны гет и сет?  Инкапсуляция?
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
