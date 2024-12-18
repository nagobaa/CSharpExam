using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the user is asked for an integer value
            Console.Write("Plese input an integer value: ");
            string integerInput = Console.ReadLine();

            //conversion of datatype string to int
            int integer = Convert.ToInt32(integerInput);

            //the user is asked for a double value
            Console.Write("Please input a double value: ");
            string double1Input = Console.ReadLine();

            //conversion of datatype string to double
            double double1 = Convert.ToDouble(double1Input);

            //the user is asked for a float value
            Console.Write("Plese input a float value: ");
            string float1Input = Console.ReadLine();

            //conversion of datatype string to float
            float float1 = Convert.ToSingle(float1Input);

            //the user is asked for a string value
            Console.Write("Please enter a string value: ");
            string string1 = Console.ReadLine();

            //printing out all the asked variable values
            Console.WriteLine($"The integer is {integer}, the double is {double1}, the float is {float1}, and the string is {string1}");

            //explaining of the datatypes
            Console.WriteLine("\n'integer' betyder heltal med omfattning av -2,147,483,648 till 2,147,483,647");
            Console.WriteLine("'double' betyder ett tal med decimaltal, de 15-16 första av dem är betydelsefulla");
            Console.WriteLine("'float' betyder ett tal med decimaltal, de 7 första av dem är betydelsefulla");
            Console.WriteLine("'string' betyder att datan sparas som tecken");
        }
    }
}
