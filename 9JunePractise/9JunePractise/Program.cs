using _9JunePractise.Extensions;
using System;

namespace _9JunePractise
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Abdulla";

            //Console.WriteLine(name.ReverseWord());

            int[] numbers = { 1,2,3};

            numbers = numbers.AddElement(4);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
