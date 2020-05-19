using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IPersonDB
    {
        Person GetUsernameByUID(int uid);
        Person GetBalanceByUID(int uid);
        Person GetBalanceByUsername(string Username);
        float AddCashWithUID(int UID, float cash);
        float AddCashWithUsername(string Username, float cash);
    }
}
