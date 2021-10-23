using ConsoleCalculator.Core;
using System;
using System.Text.RegularExpressions;

namespace ConsoleCalculator.CLI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintUsage();
            }
            else
            {
                var joinedArgs = string.Join(" ", args);
                var regex = @"-op [\+\-\*\/] -l [-0-9]+ -r [-0-9]+";

                if (Regex.IsMatch(joinedArgs, regex))
                {
                    int _left = Int32.Parse(args[3]);
                    int _right = Int32.Parse(args[5]);
                    string _operator = args[1];

                    var _operation = new Operation(_operator, _left, _right);
                    var _result = _operation.DoOperation();

                    Console.WriteLine($"Result is: {_result}");
                }
                else
                {
                    PrintUsage();
                }
            }
        }

        public static void PrintUsage()
        {
            Console.WriteLine($"Welcome to ConsoleCalculator!");
            Console.WriteLine($"");
            Console.WriteLine($"-op Operator, it must be +,-,*,/");
            Console.WriteLine($"-l Left number");
            Console.WriteLine($"-r Left number");
            Console.WriteLine($"");
            Console.WriteLine($"Example usage: -op + -l 5 -r 6");
        }
    }
}
