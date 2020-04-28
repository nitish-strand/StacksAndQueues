using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndOueuesUsingLinkedList
{
    public class Node
    {
        public object data;
        public Node next;
        public Node(object data)
        {
            this.data = data;
            next = null; //not necessory by default its null( as it is reference type/ value types are zero)
        }


    }
}
