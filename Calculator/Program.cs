// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string op;
            int res;

            Console.WriteLine("Hello, welcome to the calculator program");
            
            Console.WriteLine("Please select the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please select the second number:");
            num2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please select the operation: + - * /");
            op = Console.ReadLine();

            if(op == "+")
            {
                res = num1 + num2;
                Console.WriteLine("The result is: " + res);
            }
            else if(op == "-")
            {
                res = num1 - num2;
                Console.WriteLine("The result is: " + res);
            }
            else if (op == "*")
            {
                res = num1 * num2;
                Console.WriteLine("The result is: " + res);
            }
            else if (op == "/")
            {
                res = num1 / num2;
                Console.WriteLine("The result is: " + res);
            }
            else
            {
                Console.WriteLine("Error: Please select a valid operation");
            }
            Console.ReadKey();
        }
    }
}