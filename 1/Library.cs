using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class Library
    {
        public string Name { get; set; }
        public string Adres { get; set; }
        public int God { get; set; }
        public Library()
        {
            Name = null;
            Adres = null;
            God = 0;
        }
        public void GetInfo()
        {
            Console.WriteLine("Имя: {0} Адрес: {1} Год создания: {2}", Name, Adres, God);
        }
        public void SetInfo()
        {
            Console.WriteLine("Введите имя: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите год открытия: ");
            God = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите адрес: ");
            Adres = Console.ReadLine();
        }
        }
    }
