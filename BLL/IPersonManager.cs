using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IPersonManager
    {
        Person GetUsernameByUID(int uid);
        Person GetBalanceByUID(int uid);
        Person GetBalanceByUsername(string Username);
        float AddCashWithUID(int UID, float cash);
        float AddCashWithUsername(string Username, float cash);

        int ShowQuotasByUID(int UID);

        int ShowQuotasByUsername(string username);

    }
}
