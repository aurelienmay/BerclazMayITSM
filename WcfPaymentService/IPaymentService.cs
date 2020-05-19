using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfPaymentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator" in both code and config file together.
    [ServiceContract]
    public interface IPaymentService
    {
        [OperationContract]
        string GetUsernameByUID(int uid);

        [OperationContract]
        float GetBalanceByUID(int uid);

        [OperationContract]
        float GetBalanceByUsername(string Username);

        [OperationContract]
        float AddCashWithUID(int UID, float cash);

        [OperationContract]
        float AddCashWithUsername(string Username, float cash);

        [OperationContract]
        int ShowQuotasByUID(int UID);

        [OperationContract]
        int ShowQuotasByUsername(string username);
    }
}
