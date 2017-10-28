using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTClient
{
    [ServiceContract]
    public interface IRESTService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", 
            BodyStyle = WebMessageBodyStyle.Wrapped, 
            UriTemplate = "xml/{value}")]
        string GetDataXML(string value);

        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/{value}")]
        string GetDataJSON(string value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }
}
