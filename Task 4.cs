using System;

class Program
{
    static void Main(string[] args)
    {
        //the user is asked for a number
        Console.Write("Enter the first number: ");
        string input1Input = Console.ReadLine();
        
        //conversion to int
        int input1 = Convert.ToInt32(input1Input);
        
        //the user is asked for a number
        Console.Write("Enter the second number: ");
        string input2Input = Console.ReadLine();

        //conversion to int
        int input2 = Convert.ToInt32(input2Input);

        //defining the variables and calling for functions
        int sum = Add(input1, input2);
        int difference = Subtract(input1, input2);
        int product = Multiply(input1, input2);
        double quotient = Divide(input1, input2);

        //printing the results
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The difference of the numbers is: {difference}");
        Console.WriteLine($"The product of the numbers is: {product}");
        Console.WriteLine($"The quotient of the numbers is: {quotient}");

        Console.ReadLine();
    }

    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }


    static int Multiply(int num1, int num2)
    {
        return num1 * num2; 
    }

    static double Divide(int num1, int num2)
    {
        return (double)num1 / (double)num2;
    }
}
