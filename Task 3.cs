using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //creating the first array with values
            string[] array1 = new string[] { "Alice", "John", "Mia" };

            //creating the second array with values
            int[] array2 = new int[] { 12, 45, 78, 3, 99, 21, 8 };

            //looping throught each element in the first array
            for (int i = 0; i < array1.Length; i++)
            {
                //printing "Hello" before each name
                Console.WriteLine("Hello " + array1[i]);
            }

            //sorting the second array into first ascending order...
            Array.Sort(array2);

            //...and then reversing it to descending order
            Array.Reverse(array2);

            //removing the last element in the second array
            //deleting elements from an array is impossible, therefore the array is converted into a list
            List<int> list = new List<int>(array2);

            //deleting the last element on the list
            list.Remove(list[6]);

            //converting the list back to an array
            int[] array3 = list.ToArray();

            //empty line
            Console.WriteLine();

            //printing the second array
            //message
            Console.Write("\nThe elements of the second array, with the last element removed, in descending order are: ");
            //looping through the elements
            for (int i = 0; i < array3.Length; i++)
            {
                //printing the elements on the same row
                Console.Write(" " + array2[i] + " ");
            }
        }
    }
}
