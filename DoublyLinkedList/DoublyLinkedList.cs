using System;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        
        public DoublyLinkedList(T data)
        {
            Node<T> newNode = new Node<T>(data);

            Head = newNode;
            Tail = newNode;
            Count = 1;
        }

        public void AddNode(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if(Head == null)
            {
                Head = newNode;
                Tail = newNode;
                Count = 1;

                return; // использовать конструкцию if(isTrue) return; тоже самое что if(isTrue){} else{}?
            }

            Tail.Next = newNode;
            newNode.Previous = Tail;
            Tail = newNode;

            Count++;
        }

        public void RemoveNodeWithData(T data)
        {
            Node<T> currentNode = Head;

            while(currentNode != null)
            {
                if(currentNode.Data.Equals(data))
                {
                    currentNode.Previous.Next = currentNode.Next;
                    currentNode.Next.Previous = currentNode.Previous;

                    Count--;
                    return;
                }

                currentNode = currentNode.Next;
            }
        }

        public DoublyLinkedList<T> Reverse()
        {
            DoublyLinkedList<T> result = new DoublyLinkedList<T>();

            Node<T> currentNode = Tail;
            while(currentNode != null)
            {
                result.AddNode(currentNode.Data);

                currentNode = currentNode.Previous;
            }

            return result;
        }

        public void ToArray()
        {
            // Implement
        }

        public void Avarage()
        {
            //list.Average();
        }

        public void OutputList()
        {
            Node<T> runner = Head;

            while (runner != null)
            {
                Console.WriteLine(runner.Data);
                runner = runner.Next;
            }
        }
    }
}
