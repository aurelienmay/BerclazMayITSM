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
            ServiceReferencePayment.PaymentServiceClient service = new ServiceReferencePayment.PaymentServiceClient();

            var id = 2;
            var username = service.GetUsernameByUID(id);
            Console.WriteLine($"Person with id {id}: {username}");

            var balance = service.GetBalanceByUID(id);
            Console.WriteLine("Current balance for UID " + id + " : " + balance);

            var add = service.AddCashWithUID(id, 1000);
            Console.WriteLine("Current balance for UID " + id + " after add : " + add);

            Console.ReadKey();

        }
    }
}
