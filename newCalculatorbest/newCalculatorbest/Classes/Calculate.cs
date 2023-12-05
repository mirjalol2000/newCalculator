using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newCalculatorbest.Classes
{
    public class Calculate:ICalculate
    {
        public List<string> history = new List<string>();
        public string Name { get; set; }
        public double FirstNumber { get; set; }
        public string Function { get; set; }
        public double SecondNumber { get; set; }

        public Calculate(string name, double firstNumber, string function, double secondNumber)
        {
            Name = name;
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Function = function;
            /* History = new List<string>();*/
        }

        public virtual void CalculateAllFunctions()
        {
            double result = 0;
            switch (this.Function)
            {
                case "+":
                    result = Addition(this.FirstNumber, this.SecondNumber);
                    break;
                case "-":
                    result = Subtraction(this.FirstNumber, this.SecondNumber);
                    break;
                case "/":
                    result = Division(this.FirstNumber, this.SecondNumber);
                    break;
                case "*":
                    result = Multiplication(this.FirstNumber, this.SecondNumber);
                    break;
                case "^":
                    result = DegreeOfNumber(this.FirstNumber, this.SecondNumber);
                    break;
                default:
                    result = 0;
                    break;
            }

            Console.WriteLine($"result: {this.FirstNumber} {this.Function} {this.SecondNumber} = {result}");

            string operation = $"result: {this.FirstNumber} {this.Function} {this.SecondNumber} = {result}";
            history.Add(operation);
            
        }

        //show history
        public void ShowHistory()
        {
            foreach(var his in history)
            {
                Console.WriteLine("History : "+his);
            }
        }
        public double DegreeOfNumber(double firstNumber, double secondNumber)
        {
            double result = Math.Pow(firstNumber, secondNumber);
            return result;
        }

        private double Addition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        private double Subtraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        private double Division(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
        private double Multiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
    }
