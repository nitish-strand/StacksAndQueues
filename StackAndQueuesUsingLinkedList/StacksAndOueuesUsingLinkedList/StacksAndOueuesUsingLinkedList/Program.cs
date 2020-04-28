using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndOueuesUsingLinkedList
{
    class Program
    {
        static void PrintLinkedList(Node head)
        {
            Console.Write("Elements in Linked List:- ");
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

        static void PrintLinkedList_BtoA(Node tail)
        {
            Console.Write("Elements in Linked List:- ");
            Node current = tail;
            while (current != null)
            {
                Console.Write(current.data+" ");
                current = current.next;
            }
            Console.WriteLine();
        }

        static void PrintLinkedList_AtoB(Node head)
        {
            Console.Write("Elements in Linked List:- ");
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

        static void ReverseList(Node head)
        {
            Console.WriteLine("Reversing linked list.");
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        static void Main(string[] args)
        {
            #region Stack ClientEntry
            /*
            Stacks newStk = new Stacks();

            newStk.push("hello");
            newStk.push("nitish");
            newStk.push(234);
            newStk.push(200.89);
            newStk.push("hello1");
            newStk.push("nitish1");
            newStk.Peek();
            newStk.pop();
            PrintLinkedList_BtoA(newStk.top);
            newStk.push(2341);
            newStk.push(200.189);
            newStk.push("hello2");
            newStk.push("nitish2");
            newStk.push(2342);
            newStk.push(200.289);
            newStk.push("topmost");
            PrintLinkedList_BtoA(newStk.top);
            newStk.Peek();
            newStk.pop();
            PrintLinkedList_BtoA(newStk.top);
            */
            #endregion Stack ClientEntry

            #region Queue ClientEntry
            /*
            Queues newQue = new Queues();

            newQue.Enqueue(12);
            newQue.Enqueue("hello");
            newQue.Enqueue("bye");
            newQue.Enqueue(90.12);
            newQue.Enqueue(true);
            newQue.Enqueue("something something");
            newQue.Enqueue(12);
            newQue.Enqueue("hello");
            newQue.Enqueue("bye");
            newQue.Enqueue(90.12);
            newQue.Enqueue(true);
            newQue.Enqueue("something something");

            PrintLinkedList_AtoB(newQue.front);
            newQue.Dequeque();
            newQue.Dequeque();
            PrintLinkedList_AtoB(newQue.front);
            newQue.Dequeque();
            newQue.Dequeque();
            PrintLinkedList_AtoB(newQue.front);
            newQue.Dequeque();
            newQue.Dequeque();
            PrintLinkedList_AtoB(newQue.front);
            newQue.Dequeque();
            newQue.Dequeque();
            PrintLinkedList_AtoB(newQue.front);
            newQue.Dequeque();
            newQue.Dequeque();
            PrintLinkedList_AtoB(newQue.front);
            newQue.Dequeque();
            newQue.Dequeque();
            PrintLinkedList_AtoB(newQue.front);
            newQue.Dequeque();
            newQue.Dequeque();
            */
            #endregion Queue ClientEntry

            #region ReversingList ClientEntry
            /*
            Queues newQue = new Queues();
            newQue.Enqueue(12);
            newQue.Enqueue(32);
            newQue.Enqueue(56);
            newQue.Enqueue(11);
            newQue.Enqueue(33);
            newQue.Enqueue(5);
            newQue.Enqueue(10);
            newQue.Enqueue(30);
            newQue.Enqueue(50);

            PrintLinkedList(newQue.front);
            ReverseList(newQue.front);
            PrintLinkedList(newQue.rear);
            */
            #endregion ReversingList ClientEntry

            Console.ReadLine();

        }
    }
}
