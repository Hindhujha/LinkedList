using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList 
    {
        internal Node head; // starting point of linked list
        internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted into linked list", node.data);
        }

        internal void Display()
        {
            Node temp = this. head;
            if(temp==null)
            {
                Console.WriteLine("LINKED LIST IS EMPTY");
            }
            while(temp!=null)
            {
                Console.WriteLine(" " + temp.data);
             temp=temp.next;
            }
        }
        //INSERT A NODE BETWEEN TWO NODES
        internal  Node InsertInPosition(int position,int data)
        {

           
            if (position<1)
            {
                Console.WriteLine("INVALID POSITION");
            }
            if(position == 1)
            {
              Node  newNode = new Node(data);
                newNode.next = this.head;
                head = head.next;
             
            }
            else
            {
                while(position-- !=0)
                {
               
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        break;
                        
                    }
                    head = head.next;
                    if (position!=1)
                    {
                        Console.WriteLine("POSITION OUT OF RANGE");
                    }
                }             
            }

            Console.WriteLine("INSERTED VALUE IS :" + head.next.data);
            return head;
        }
        //Remove First Node
        internal Node RemoveFirstNode()
        {
            if(this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;

        }
        //Remove Last Node
        internal Node RemoveLastNode()
        {
            if(head == null)
            {
                return null;
            }
            if(head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while(NewNode.next.next!= null)
            {
                NewNode= NewNode.next;
            }
            NewNode.next = null;
            return head;
        }
    }
}
