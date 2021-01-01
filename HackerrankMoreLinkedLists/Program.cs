using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankMoreLinkedLists
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    class Program
    {
        

        public static Node removeDuplicates(Node head)
        {    
            Node current = head; Node temp = null;
            while (current != null)
            {
                temp = current;
                Node index = head;
                Node imp = null;
                Node previous = null;
                while (index != null)
                {
                    imp = index;
                    if (imp != temp)
                    {
                        if (temp.data == imp.data)
                        {
                            previous.next = imp.next;
                            imp = null;
                        }
                    }
                    if (imp != null)
                    {
                        previous = imp;
                    }
                    index = index.next;
                }
                current = current.next;
            }
                return head;       
        }
        //static /*Node*/ void  AddNode(int position, int data)
        //{
        //    Node node = new Node(data);
        //    if (position < 1)
        //    {
        //        if (size == 0)
        //        {
        //            head = node;
        //            tail = node;

        //        }
        //        else
        //        {
        //            node.Next = head;
        //            head = node;

        //        }
        //        size++;
        //        return;
        //    }
        //    else if (position >= size)
        //    {
        //        if (size == 0)
        //        {
        //            head = null;
        //            tail = null;
        //        }
        //        else
        //        {
        //            tail.Next = node;
        //            tail = node;
        //        }
        //        size++;
        //        return;
        //    }
        //    Node current = head;
        //    Node temp = null;
        //    for (int i = 0; i < position; i++)
        //    {
        //        temp = current;
        //        current = current.Next;
        //    }
        //    temp.Next = node;
        //    node.Next = current;
        //    size++;



        //    //return new_node;
        //}
        //static void printinfo(/*Node head*/)
        //{
        //    Node currentnode = head;
        //    Console.WriteLine("Size " + size);

        //    while (currentnode != null)
        //    {

        //        Console.Write(currentnode+"\t");
        //        currentnode = currentnode.Next;



        //    }
        //}
      public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                {
                    start = start.next;
                 

                }
                start.next = p;
            }
            return head;
        }
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(string[] args)
        {
            //Node p=null;
            Console.OutputEncoding = Encoding.UTF8;
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
         head = removeDuplicates(head);
            display(head);

            Console.ReadLine();
        }
    }
}
