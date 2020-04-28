using System;

namespace StackAndQueuesArrays
{
    public class Queue<T>
    {
        int front;
        int rear;
        int _size;
        T[] ArrayQueue;

        public Queue(int size)
        {
            _size = size;
            front = rear = 0;
            ArrayQueue = new T[size];

        }
        public void Enqueue(T data)
        {
            if(rear == _size - 1)
            {
                Console.WriteLine("ArrayOverFlowException");
            }
            else
            {
                ArrayQueue[rear++] = data;
                Console.WriteLine("{0} has been Queued",data);
            }
            
        }

        public void Dequeue()
        {
            if(IsEmpty())
            {
                return;
            }
            else
            {
                Console.WriteLine("{0} in front of the queue is dequeued", ArrayQueue[front]);
                for (int i = front; i < rear; i++)
                {
                    ArrayQueue[i] = ArrayQueue[i + 1];
                }
                rear--;
            }
        }

        public void PrintArrayQueue()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                Console.Write("Here's the list of elements in the Queue:- ");
                for(int i = 0; i < rear; i++)
                {
                    Console.Write(ArrayQueue[i]+" ");
                }
                Console.WriteLine();
            }

        }

        private bool IsEmpty()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return true;
            }
            else return false;
        }

        public void PeekFront()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                Console.WriteLine("{0} is in the front of the queue",ArrayQueue[front]);
            }
        }

        public void PeekRear()
        {
            if (IsEmpty())
            {
                return;
            }
            else
            {
                Console.WriteLine("{0} is in the rear of the queue", ArrayQueue[rear-1]);
            }
        }
    }
}
