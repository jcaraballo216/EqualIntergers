using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualIntergers
{
    class Program
    {
        static void Main(string[] args)
        //Asking user to type in two numbers to see if they are equal 
        {
            Console.WriteLine("Please enter a number!");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number!");
            int secondNumber = int.Parse(Console.ReadLine());
        //See if numbers are equal 
            if (number == secondNumber)
            {
                Console.WriteLine("Numbers" + number +"and" + secondNumber + "are equal");
            }
            else
            {
                Console.WriteLine("Numbers" + number +  "and" + secondNumber + "are not equal");
            }


        }
    }
}
