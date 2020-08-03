using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyArray = new string[] { "Zebra", "Ant", "Owl", "Lion" };
            var animals = new string[] { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            var places = new string[] { "Africa", "New Zealand", "Jamaica", "India" };

            Array.Sort(MyArray);
            Array.Sort(animals);
            Array.Sort(places);

            //Array.Reverse(animals);

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine("This is for loop ..." + MyArray[i]);
            }
            Console.WriteLine("..................");

            foreach (string i in MyArray)
            {
                Console.WriteLine("This is foreach loop ..." + i);
            }

            Console.WriteLine("..................");

            int a = 0;
            while (a < MyArray.Length)
            {
                Console.WriteLine("This is for while loop..... " + MyArray[a]);
                a++;
            }

            Console.WriteLine("..................");

            int x = 0;
            do
            {
                Console.WriteLine("This is for Do-while loop ...." + MyArray[x]);
                x++;
            }
            while (x < MyArray.Length);

            Console.WriteLine();
            Console.WriteLine(".........animals.........");

            foreach (string an in animals)
            {
                Console.WriteLine("This is foreach loop ..." + an);
            }
            Console.WriteLine();
            Console.WriteLine("........places ..........");

            foreach (string p in places)
            {
                Console.WriteLine("This is foreach loop ..." + p);
            }

        }
    }
}
