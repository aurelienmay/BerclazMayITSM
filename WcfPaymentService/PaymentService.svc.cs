using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfPaymentService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class PaymentService : IPaymentService
    {
        public string GetUsernameByUID(int uid)
        {
            IPersonDB userDb = new PersonDB();
            IPersonManager userManager = new PersonManager(userDb);
            var user = userManager.GetUsernameByUID(uid);
            return user.Username;
        }

        public float GetBalanceByUID(int uid)
        {
            IPersonDB userDb = new PersonDB();
            IPersonManager userManager = new PersonManager(userDb);
            var user = userManager.GetBalanceByUID(uid);
            return user.Balance ;
        }

        public float GetBalanceByUsername(string Username)
        {
            IPersonDB userDb = new PersonDB();
            IPersonManager userManager = new PersonManager(userDb);
            var user = userManager.GetBalanceByUsername(Username);
            return user.Balance;
        }

        public float AddCashWithUID(int UID, float cash)
        {
            IPersonDB userDb = new PersonDB();
            IPersonManager userManager = new PersonManager(userDb);
            float result = userManager.AddCashWithUID(UID, cash);
            // Return the total cash in the balance
            return result;
        }

        public float AddCashWithUsername(string Username, float cash)
        {
            IPersonDB userDb = new PersonDB();
            IPersonManager userManager = new PersonManager(userDb);
            float result = userManager.AddCashWithUsername(Username, cash);
            // Return the total cash in the balance
            return result;
        }

        public int ShowQuotasByUID(int UID)
        {
            IPersonDB userDb = new PersonDB();
            IPersonManager userManager = new PersonManager(userDb);
            int result = userManager.ShowQuotasByUID(UID);
            // Return the total cash in the balance
            return result;
        }

        public int ShowQuotasByUsername(string username)
        {
            IPersonDB userDb = new PersonDB();
            IPersonManager userManager = new PersonManager(userDb);
            int result = userManager.ShowQuotasByUsername(username);
            // Return the total cash in the balance
            return result;
        }
    }
}
