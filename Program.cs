using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Node
    {
        public Node next;
        public int data;

        public Node(int data)
        {
            this.data = data;
        }
    }

    public class LinkedList
    {
        Node head;
        public void Insert(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }
            if (head.data >= data)
            {
                Node newHead = new Node(data);
                newHead.next = head;
                head = newHead;
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                if (current.next.data >= data)
                {
                    var temp = current.next;
                    current.next = new Node(data);
                    current.next.next = temp;
                    break;
                }
                else
                {
                    current = current.next;
                }

            }
            if (current.next == null)
            {
                current.next = new Node(data);
            }
        }

        public void Delete(int data)
        {
            if (head == null) return;
            if (head.data == data)
            {
                head = head.next;
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
            head = null;

        }
        public void Show()
        {
            Console.Write("list: ");
            Node current = head;
            while (current != null)
            {
                var x = current.data;
                Console.Write(x + " ");
                current = current.next;

            }
            if (head == null)
            {
                Console.WriteLine("empty");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Completed by: Muhammad Iqbal Fajar, Scott Hook, and Viktoriya Grishkina\n");
            Console.WriteLine("list: empty");
            LinkedList list = new LinkedList();

            do
            {
                Console.WriteLine("Available commands are: add, remove. Type \"quit\" to exit the program");
                string userInput1 = Console.ReadLine();
                if (userInput1 == "add")
                {
                    do
                    {
                        Console.WriteLine("Input a number. Type \"return\" to go back.");
                        string userInput2 = Console.ReadLine();

                        if (userInput2 == "return")
                        {
                            break;
                        }
                        else if (userInput2 == "quit")
                        {
                            continue;
                        }
                        else
                        {
                            var convertion = Int32.Parse(userInput2);
                            //Console.WriteLine("Got here #1");
                            //insert function
                            list.Insert(convertion);
                            //show list function
                            list.Show();
                            continue;
                        }
                    }
                    while (true);
                }
                else if (userInput1 == "remove")
                {
                    Console.WriteLine("Input a number you want to remove. Type \"return\" to go back.");
                    int userInput3 = Int16.Parse(Console.ReadLine());
                    //Console.WriteLine("Got here #2");
                    //delete function
                    list.Delete(userInput3);
                    //show list function
                    list.Show();
                    continue;
                }
                else if (userInput1 == "quit")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            while (true);

        }
    }
}
