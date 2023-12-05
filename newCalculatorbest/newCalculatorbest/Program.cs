using newCalculatorbest.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newCalculatorbest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Calculator\n2.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    double firstNumber, secondNumber;

                    Console.Write("Your name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the first number :");
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                key:
                    Console.Write("Enter the operation like +,-,*, / , % or ^:");
                    string function = Console.ReadLine();
                    while (true)
                    {

                        if (function == "+" || function == "-" || function == "*" || function == "/" || function == "^")
                        {
                            break;
                        }
                        else
                        {
                            goto key;
                        }
                    }
                    Console.Write("Enter the second number :");
                    secondNumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Result : ");

                    if (function == "prc")
                    {
                        AdvancedCalculate advancedCalculate = new AdvancedCalculate(name, firstNumber, function, secondNumber);
                        advancedCalculate.CalculateAllFunctions();
                        Console.WriteLine("Do you want to see history ? y/n");
                        string s = Console.ReadLine();
                        if (s == "y")
                        {
                            advancedCalculate.ShowHistory();
                        }
                        else
                        {
                            Console.WriteLine("Thanks for using our app");
                        }
                    }
                      
                    else
                    {
                        ICalculate calculate = new Calculate(name, firstNumber, function, secondNumber);
                        calculate.CalculateAllFunctions();
                        Console.WriteLine("Do you want to see history ? y/n");
                        string s = Console.ReadLine();
                        if(s == "y")
                        {
                            calculate.ShowHistory();
                        }
                        else
                        {
                            Console.WriteLine("Thanks for using our app");
                        }
                    }
                }
                /*else if (choice == 2)
                {
                    Calculate calculator = new Calculate();

                }*/
                else
                {
                    break;
                }

            }




            Console.ReadKey();
        }
    }
}
