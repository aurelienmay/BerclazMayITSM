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
    }
}
