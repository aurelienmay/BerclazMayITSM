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
            PaymentService.PaymentServiceClient service = new PaymentService.PaymentServiceClient();

            var id = 2;
            var username = service.GetUsernameByUID(id);
            Console.WriteLine($"Person with id {id}: {username}");


            var balance = service.GetBalanceByUID(id);
            Console.WriteLine("Current balance for UID " + id + " : " + balance);

            var add = service.AddCashWithUID(id, 1000);
            Console.WriteLine("Current balance for UID " + id + " : " + add);

            Console.ReadKey();

        }
    }
}
