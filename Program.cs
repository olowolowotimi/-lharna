using System;

namespace lharna
{
    class Program
    {
        static void Main(string[] args)
        {
            int Length, Breadth;
            int Perimeter;
            Console.WriteLine("enter your length");
            Length=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your breadth");
            Breadth=Convert.ToInt32(Console.ReadLine());
            Perimeter=2 *(Length+Breadth);
            Console.WriteLine("The perimeter of a rectangle="+ Perimeter);
        }
    }
}
