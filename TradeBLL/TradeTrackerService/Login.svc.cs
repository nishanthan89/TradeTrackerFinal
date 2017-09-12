using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TradeDAL;


namespace TradeBLL.TradeTrackerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Login" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Login.svc or Login.svc.cs at the Solution Explorer and start debugging.
    public class Login : ILogin
    {
    
       UserDAL UserDAL = new UserDAL();
        public string GetLoginDetail(loginDALModel loginDetail)
        {

            string loginResult = UserDAL.AddUserDetails(loginDetail);
            return loginResult;
        }


        public string RegisterUser(loginDALModel registeruser)
        {
            try {

                UserDAL.RegisterUser(registeruser);
            }
            catch {
                
            }

            return registeruser.ToString();
           // throw new NotImplementedException();
            
            
        }
    }
    
}
