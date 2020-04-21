using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager : IUserManager
    {
        private IUserDB UserDb { get; }

        public UserManager(IUserDB userDb)
        {
            UserDb = userDb;
        }

        public User GetUserByUID(int uid)
        {
            return UserDb.GetUserByUID(uid);
        }
    }
}
