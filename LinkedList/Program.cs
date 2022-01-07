using System;
using System.Collections.Generic;
//LINKED LIST PROBLEMS
namespace LinkedList
{ 
    class Programg
    {
        static void Main(string[] args)
        {//creating a linked list
            LinkedList list=new LinkedList();
            //adding values in linked list
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.Display();         
            list.Arranged_In_Sequence();
            Console.WriteLine("AFTER ARRANGED IN SEQUENCE");
            list.Display();
            list.DeleteNodebyKey(40);
            Console.WriteLine("AFTER DELETING A NODE 40");
            list.Display();
            list.InsertInPosition(2,30);//inserting 30 in second position
            list.RemoveFirstNode();
            list.RemoveLastNode();
            list.Search(30);//searching 30 in linked list


        }
    }
}
