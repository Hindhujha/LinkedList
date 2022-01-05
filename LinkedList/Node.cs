using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   internal class Node
    {
        public int data;//values in node
        public Node next;//address of the next node
        public Node (int data)
        {
            this.data = data;
        }
    }
}
