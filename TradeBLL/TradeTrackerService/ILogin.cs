using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Text;
using TradeDAL;

namespace TradeBLL.TradeTrackerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILogin" in both code and config file together.
    [ServiceContract]
    public interface ILogin
    {
        [OperationContract]
        [WebInvoke(
            Method="GET",
            UriTemplate="/",
            RequestFormat=WebMessageFormat.Json,
            ResponseFormat=WebMessageFormat.Json,
            BodyStyle=WebMessageBodyStyle.Wrapped
            )
        ]

        string GetLoginDetail(loginDALModel loginDetail1);
        
        string RegisterUser(loginDALModel registeruser);
    }
}
