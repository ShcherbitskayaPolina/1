using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод данных");
            Library l = new Library();
            l.SetInfo();
            l.GetInfo();
            Console.ReadKey();

        }
    }
}
