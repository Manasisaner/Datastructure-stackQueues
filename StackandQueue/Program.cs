// See https://aka.ms/new-console-template for more information
using System;
using StackandQueue;
class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome In Stack and Queue Operation");
        StackandQueue stack = new StackandQueue();
    Console.WriteLine("Display Stack Elements 1\n Peek And Pop Operation 2\n Deleting Top of the Elements Of Stack 3\n Checking Stack is Empty 4\n Display Queue Elements 5\n Delete Elements From Queues 6\n");
        bool check = true;
        while (check)
        { 
        Console.WriteLine("Enter the Above Option To Perform the Operation");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
        {
        case 1: 
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                case 2:
                    stack.Peek();
                    break;

            }
       }
    }
}

