using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the user is asked for a number
            Console.Write("Please input a number: ");

            //the input is stored to a string variable
            string numberInput = Console.ReadLine();

            //trying the conversion of string datatype to int
            int number;
            if (int.TryParse(numberInput, out number))
            {
                //use of if-statement to check for...
                //...positive value
                if (number > 0)
                {
                    //printing the result
                    Console.WriteLine("The number is positive");
                }
                //...negative value
                if (number < 0)
                {
                    //printing the resutl
                    Console.WriteLine("The number is negative");
                }
                //...is cero
                if (number == 0)
                {
                    //printing the result
                    Console.WriteLine("The number is zero");
                }               
            }
            //in case of invalid input
            else
            {
                Console.WriteLine("Invalid input");
            }    
        }
    }
}
