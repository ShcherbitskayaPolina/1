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

    }
}
