using System;
using System.Collections.Generic;

namespace M1Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Hello");
            names.Push("Hii");
            names.Push("Hey");
            names.Push("Bye");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek element:" + names.Peek());
            Console.WriteLine("element poped:" + names.Pop());
            Console.WriteLine("Peek element after pop:"+names.Peek());
        }
    }
}
