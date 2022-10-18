using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();

            doublyLinkedList.AddNode(1);
            doublyLinkedList.AddNode(22);
            doublyLinkedList.AddNode(-5);
            doublyLinkedList.AddNode(7);

            doublyLinkedList.OutputList();
            Console.WriteLine();

            //doublyLinkedList.RemoveNodeWithData(-5);

            /*DoublyLinkedList<int> reversedList = doublyLinkedList.Reverse();
            reversedList.OutputList();
            Console.WriteLine();*/

            List<int> list = new List<int>(); // list. в подсказках ничего не понятно, как правильно их читать, смотреть документацию?
                                              // list.Clear(); hot to implement?
            Console.ReadKey();
        }
    }
}
