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

        public Person GetBalanceByUsername(string Username)
        {
            return UserDb.GetBalanceByUsername(Username);
        }

        public float AddCashWithUID(int UID, float cash)
        {
            return UserDb.AddCashWithUID(UID, cash);
        }

        public float AddCashWithUsername(string Username, float cash)
        {
            return UserDb.AddCashWithUsername(Username, cash);
        }

        public int ShowQuotasByUID(int UID)
        {
            float balance = GetBalanceByUID(UID).Balance;

            return Convert.ToInt32(Math.Floor(balance / 0.08));
        }

        public int ShowQuotasByUsername(string username)
        {
            float balance = GetBalanceByUsername(username).Balance;

            return Convert.ToInt32(Math.Floor(balance / 0.08));
        }
    }
}
