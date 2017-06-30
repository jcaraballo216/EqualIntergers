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
            //                Console.WriteLine("Please enter a number!");
            //                int number = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Please enter a second number!");
            //                int secondNumber = int.Parse(Console.ReadLine());
            //            //See if numbers are equal 
            //                if (number == secondNumber)
            //                {
            //                    Console.WriteLine("Numbers" + number +"and" + secondNumber + "are equal");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Numbers" + number +  "and" + secondNumber + "are not equal");
            //                }


            ////Even or Odd


            ////Ask user for a number
            //            Console.WriteLine("Welcome to Odd or Even!");

            //            Console.WriteLine("Please enter a number!");
            //            int numberOne = int.Parse(Console.ReadLine());
            //            //See if numbers are odd or even
            //            if (number % 2 == 0)
            //            {
            //                Console.WriteLine("Number entered is Even!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Number entered is Odd!");
            //            }

            //            //Positive or Negative
            //            //Ask user to type a number
            //            //Tell wheter its positive or negative
            //            //User inputs zero results in error

            //                Console.WriteLine("Positive or Negative!");
            //                Console.WriteLine("Please enter a number!");
            //                int numberTwo = int.Parse(Console.ReadLine());

            //                if (number < 0)
            //                {

            //                    Console.WriteLine("The number is negative");
            //                }
            //                if (number == 0)
            //                { 
            //                    Console.WriteLine("Error! You entered Zero its niether Positve or Negative!");
            //            }
            //            if (number > 0)
            //            {
            //                Console.WriteLine("The number is positve");
            //            }
            //            else
            //                Console.WriteLine("Error! You did not type a number");
            //                {

            //                }

            //            //Vowel or Consonant
            //            //Create char variable for if-else-if statements
            //            //Ask user to type a letter
            //            //Make sure to have both lower and upper case vowels and consonants

            //            //variable created



            //                Console.WriteLine("Please type a letter!");
            //                string letter = (Console.ReadLine());

            //            //figure this out later something wrong with code
            //            if (letter == 'a' || letter == 'A')
            //            {
            //                Console.WriteLine("The letter is a vowel!");
            //            }
            //            else if (letter == 'e'  || letter =='E')
            //            {
            //                Console.WriteLine("The letter is a vowel!");
            //            }
            //            else if (letter == 'i' || letter == 'I')
            //            {
            //                Console.WriteLine("The letter is a vowel!");
            //            }
            //            else if (letter == 'o' || letter == 'O')
            //            {
            //                Console.WriteLine("The letter is a vowel!");
            //            }
            //            else if (letter == 'u' || letter == 'U')
            //            {   
            //                Console.WriteLine("The letter is a vowel!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("The letter is a consonant!");
            //            }
            //Fizz Buzz
            //Ask user for two numbers and a test number
            //int numberOne;
            ////numberOne is fizz
            //int numberTwo;
            ////numberTwo is buzz
            //int testNumber;


            //Console.WriteLine("Please enter your first number!");
            //numberOne = int.Parse(Console.ReadLine());
            //if (numberOne < 1 || numberOne > 9)
            //{
            //    Console.WriteLine("You did not follow directions! Please enter a number between 1 and 9");
            //}
            //Console.WriteLine("Please enter your second number!");
            //numberTwo = int.Parse(Console.ReadLine());
            //if (numberTwo < 1 || numberTwo > 9)
            //{
            //    Console.WriteLine("You did not follow directions! Please enter a number between 1 and 9");
            //}
            //Console.WriteLine("Please enter your Test number!");
            //testNumber = int.Parse(Console.ReadLine());
            ////calculation of fizz and buzz
            //if (testNumber % numberOne == 0 && testNumber % numberTwo == 0)
            //    {
            //    Console.WriteLine("FizzBuzz!");
            //}
            //else if (testNumber % numberOne == 0)
            //{
            //    Console.WriteLine("Fizz!");
            //}
            //else if (testNumber % numberTwo == 0)
            //{
            //    Console.WriteLine("Buzz");
            //}
            //else if (testNumber < 1 || testNumber > 9)
            //{
            //    Console.WriteLine("You did not follow directions! Please enter a number between 1 and 9");
            //}
            //else
            //{
            //    Console.WriteLine(testNumber);
            //}

            //Greater value problem
            //Ask user to input two numbers
            //Find the greater value of the two intergers
            //Make error message if user inputs words

            //first number
            int valueOne;
            //second number
            int valueTwo;
            Console.WriteLine("Hello! Welcome to <> Value. You will be asked to input two seperate numbers.");
            Console.WriteLine("Please enter your first number!");
            valueOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number!");
            valueTwo = int.Parse(Console.ReadLine());
            if (valueOne > valueTwo)
            {
                Console.WriteLine(valueOne + " is greater than "  + valueTwo);
            }
            else if (valueTwo > valueOne)
            {
                Console.WriteLine(valueTwo + " is greater than "  + valueOne);
            }
            else
            {
                Console.WriteLine("Error! You did not follow directions. Please try again!");
            }
             








            }









        }
    }

