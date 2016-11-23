using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite slovo dlya hroverki na polindrom");
            string name = Console.ReadLine();

            for (int i = 0; i < name.Length / 2; i++)
            {
                if (name[i] != name[name.Length - i - 1])
                {
                    Console.WriteLine("Slovo " + "'{0}'" + " ne polindromnoe", name);
                }
            }
            Console.WriteLine("Slovo "+"'{0}'" + " polindromnoe", name);
        }
    }
}
