using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReferenceCalculator.CalculatorClient client = new ServiceReferenceCalculator.CalculatorClient();
            var a = 6;
            var b = 2;
            
            var result = client.Add(a, b);
            Console.WriteLine($"{a} + {b} = {result}");

            result = client.Sub(a, b);
            Console.WriteLine($"{a} - {b} = {result}");

            result = client.Mult(a, b);
            Console.WriteLine($"{a} * {b} = {result}");

            result = client.Div(a, b);
            Console.WriteLine($"{a} / {b} = {result}");

            var id = 2;
            var firstname = client.GetPersonById(id);
            Console.WriteLine($"Person with id {id}: {firstname}");
            
            Console.ReadKey();
        }
    }
}
