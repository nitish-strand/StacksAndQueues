using System;

namespace StacksAndOueuesUsingLinkedList
{
    public class Stacks
    {
        public Node top { get; private set; }

        public Stacks()
        {
            this.top = null;
        }

        
        public void push(object data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;

            Console.WriteLine("{0} pushed to stack", newNode.data);
        }

        public void pop()
        {
            if (IsEmpty())
            {
                return;
            }
            Console.WriteLine("Item popped is {0}", top.data);
            top = top.next;
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                return;
            }
            Console.WriteLine("{0} is on the top of Stack", this.top.data);
        }

        private bool IsEmpty()
        {
            if(top == null)
            {
                Console.WriteLine("Stack Underflow.");
                return true;
            }
            return false;
        }
    }
}
