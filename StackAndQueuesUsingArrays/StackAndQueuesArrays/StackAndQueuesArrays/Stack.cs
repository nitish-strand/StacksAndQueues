using System;

namespace StackAndQueuesArrays
{
    public class Stack<T>
    {
        int _size;
        int top;
        T[] ArrayStack;

        public Stack(int size)
        {
            _size = size;
            ArrayStack = new T[size];
            top = -1;
        }

        public void push(T data)
        {
            // if(top > _size)
            if (top == _size-1)
            {
                Console.WriteLine("ArrayOverFlowException");
            }
            else
            {
                ArrayStack[++top] = data;
                Console.WriteLine("{0} has been stacked in array", data);
                //dont know if top++ needs to be here
            }
        }

        public void pop()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                Console.WriteLine("{0} has been pooped out of the stack", ArrayStack[top]);
                --top;
            }
            
        }

      
        public void Peek()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                Console.WriteLine("{0} is the element on top of this stack", ArrayStack[top]);
            }
        }
        

        private bool IsEmpty()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is empty");
                return true;
            }
            return false;
        }

        public void PrintArrayStack()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                Console.Write("Here is the stack array:-  ");
                for(int i =0; i<=top;i++)
                {
                    Console.Write(ArrayStack[i]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
