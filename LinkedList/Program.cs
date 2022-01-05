using System;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {//creating a linked list
            LinkedList list=new LinkedList();
            //adding values in linked list
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}
