using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TradeTrackerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILogin" in both code and config file together.
    [ServiceContract]
    public interface ILogin
    {
        [OperationContract]
        //this is for all http methods(GET,POST,DELETE,PUT) so its for configured needs
        [WebInvoke(
            Method="GET",
            UriTemplate="/",
            RequestFormat=WebMessageFormat.Json,
            ResponseFormat=WebMessageFormat.Json,
            BodyStyle=WebMessageBodyStyle.Wrapped
            )
        ]
       // [WebGet]// this is for just GET
        string GetLoginDetail(Object loginId);
    }
}
