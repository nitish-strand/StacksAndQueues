using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndOueuesUsingLinkedList
{
    public class Queues
    {
        public Node front { get; private set; }
        public Node rear { get; private set; }

        public Queues()
        {
            front = rear = null;
        }

        public void Enqueue(object data)
        {
            Node newNode = new Node(data);

            if(rear == null)
            {
                front = rear = newNode;
            }

            rear.next = newNode;
            rear = newNode;
            Console.WriteLine("{0} is queued in the list.", rear.data);
        }

        public void Dequeque()
        {
            if(front == null)
            {
                Console.WriteLine("Queue Underflow");
                return;
            }

            Console.WriteLine("Element dequeued from front of the list is:- {0}", front.data);
            front = front.next;
        }
    }
}
