using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {


        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            double answer;
            string ops;

            Console.WriteLine("\t\t\t\t\t Welcome to Toni's Calculator \n \t\t\t\t\t------------------------------");
            Console.WriteLine("Please enter a number: ");
            firstNumber = Double.Parse(Console.ReadLine());

            Console.WriteLine("Select an operator: +, -, *, /, %");
            ops = Console.ReadLine();

            Console.WriteLine("Enter another number: ");
            secondNumber = Double.Parse(Console.ReadLine());

           //What should I put the while loop equal to firstNumber == ? to make it loop
           //How to make else statement print?

           

            if (ops == "+")
            {
                Console.WriteLine("\n");
                answer = firstNumber + secondNumber;
                Console.Write("Total: " + answer);
            }

            else if (ops == "-")
            {
                Console.WriteLine("\n");
                answer = firstNumber - secondNumber;
                Console.Write("Total: " + answer);
            }

            else if (ops == "*")
            {
                Console.WriteLine("\n");
                answer = firstNumber * secondNumber;
                Console.Write("Total: " + answer);
            }

            else if (ops == "/")
            {
                Console.WriteLine("\n");
                answer = firstNumber / secondNumber;
                Console.Write("Total: " + answer);
            }

            else if (ops == "%")
            {
                Console.WriteLine("\n");
                answer = firstNumber % secondNumber;
                Console.Write("Total: " + answer);
            }

            else
            {
                Console.WriteLine("I don't understand");
            }

            Console.ReadLine();


        


            



















            //double firstNumber;
            //double secondNumber;
            //double answer;
            //string ops;

            //Console.WriteLine("\t\t\t\t\t Toni's Calculator Practice");
            //Console.WriteLine("\t\t\t\t\t--------------------------\t");

            //Console.WriteLine("\t\t\t\t\t Enter a number");
            //firstNumber = Double.Parse(Console.ReadLine());

            //Console.WriteLine("\t\t\t\t\t Select an Operator: (+, -, *, /, %)\n");
            //ops = Console.ReadLine();

            //Console.WriteLine("\t\t\t\t\t Enter second number: " );
            //secondNumber = Double.Parse(Console.ReadLine()); 

            //    if (ops == "+")
            //{
            //    Console.WriteLine("\n");
            //    answer = firstNumber + secondNumber;
            //    Console.Write("Total: " + answer);
            //}

            //if (ops == "-")
            //{
            //    Console.WriteLine("\n");
            //    answer = firstNumber - secondNumber;
            //    Console.Write("Total: " + answer);
            //}

            //if (ops == "*")
            //{
            //    Console.WriteLine("/n");
            //    answer = firstNumber * secondNumber;
            //    Console.Write("Total: " + answer);
            //}

            //if (ops == "/")
            //{
            //    Console.WriteLine("\n");
            //    answer = firstNumber / secondNumber;
            //    Console.Write("Total: " + answer);
            //}

            //if (ops == "%")
            //{
            //    Console.WriteLine("\n");
            //    answer = firstNumber % secondNumber;
            //    Console.Write("Total: " + answer);
            //}
                
            //Console.ReadKey();
          
            
            
            //int firstNumber;
            //int secondNumber;
            //string whatFunction;

            //Console.WriteLine("Welcome to Toni's Calculator \n What math function do you want to perform today?");
            //whatFunction = Console.ReadLine();

            //if (whatFunction == +, -, *, /)
            //{
            //    firstNumber = Console.WriteLine(whatFunction + " - Enter a number: ");
            //}

            //else
            //    Console.WriteLine("I don't understand");
            //    Console.ReadLine();

            //Console.WriteLine("Enter a number: ");
            //secondNumber = Convert.ToInt32(Console.ReadLine());


            
            
           
        }
    }
}
