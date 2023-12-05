using Amazon.SimpleWorkflow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newCalculatorbest.Classes
{
    public class AdvancedCalculate: Calculate, IAdvancedCalculate
    {
        public AdvancedCalculate(string name, double firstNumber, string function, double secondNumber)
            : base(name, firstNumber, function, secondNumber)
        {

        }

        public double Percentage(double firstNumber, double secondNumber)
        {
            double result = (firstNumber / 100) * secondNumber;
            return result;
        }

        public override void CalculateAllFunctions()
        {
            double result = Percentage(this.FirstNumber, this.SecondNumber);
            string operation2 = $"result: {this.FirstNumber} {this.Function} {this.SecondNumber} = {result}";
            history.Add(operation2);
            
            //Console.WriteLine($"result: {this.FirstNumber} {this.Function} {this.SecondNumber} = {result}");
        }

        public void ShowHistory()
        {
            foreach (var his in history)
            {
                Console.WriteLine("History : " + his);
            }
        }
    }
}
