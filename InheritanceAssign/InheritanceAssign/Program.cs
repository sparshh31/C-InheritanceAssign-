using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssign
{
    abstract class Quadrilateral
    {
        //public int Length;
        abstract public int Area(int Length);
    }
    class Sqaure : Quadrilateral
    {
        public override int Area(int Length)
        {
            return Length * Length;
        }
    }
    class Rectangle : Quadrilateral
    {
        int Breath;


        public Rectangle(int _breath)
        {
            Breath = _breath;
        }

        public override int Area(int Length)
        {
            return Breath * Length;
        }


        class Program
        {
            static void Main(string[] args)
            {
                Sqaure s = new Sqaure();
                Console.WriteLine("Area of square is: " + s.Area(4));

                Rectangle r = new Rectangle(6);
                Console.WriteLine("Area of rectangle is: " + r.Area(5));

                if (s.Area(4) > r.Area(5))
                {
                    Console.WriteLine("Square area is greater than Rectangle area");
                }
                else
                {
                    Console.WriteLine("Square area is smaller than Rectangle area");
                }


                Console.ReadLine();
            }

        }
    }
}