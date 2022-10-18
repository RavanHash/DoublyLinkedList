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

            doublyLinkedList.AddNodeToEnd(1);
            doublyLinkedList.AddNodeToEnd(22);
            doublyLinkedList.AddNodeToEnd(-5);
            doublyLinkedList.AddNodeToEnd(7);

            doublyLinkedList.OutputList();
            Console.WriteLine();


            Console.WriteLine(Convert.ToDouble(doublyLinkedList.Avarage()));

            /*int[] array = doublyLinkedList.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }*/

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
