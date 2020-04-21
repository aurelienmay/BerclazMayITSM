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
        private IPersonDB UserDb { get; }

        public PersonManager(IPersonDB userDb)
        {
            UserDb = userDb;
        }

        public Person GetUsernameByUID(int uid)
        {
            return UserDb.GetUsernameByUID(uid);
        }

        public Person GetBalanceByUID(int uid)
        {
            return UserDb.GetBalanceByUID(uid);
        }
    }
}
