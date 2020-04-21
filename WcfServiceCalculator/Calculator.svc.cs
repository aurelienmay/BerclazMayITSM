using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculator.svc or Calculator.svc.cs at the Solution Explorer and start debugging.
    public class Calculator : ICalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }

        public double Mult(double a, double b)
        {
            return a * b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public string GetPersonById(int id)
        {
            IPersonDB personDb = new PersonDB();
            IPersonManager personManager = new PersonManager(personDb);
            var person = personManager.GetPersonById(id);
            return person.FirstName;
        }
    }
}
