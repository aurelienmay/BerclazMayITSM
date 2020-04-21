using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PersonManager : IPersonManager
    {
        private IPersonDB PersonDb { get; }

        public PersonManager(IPersonDB personDb)
        {
            PersonDb = personDb;
        }

        public Person GetPersonById(int id)
        {
            return PersonDb.GetPersonById(id);
        }
    }
}
