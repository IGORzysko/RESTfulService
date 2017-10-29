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
            ResponseFormat = WebMessageFormat.Xml, 
            UriTemplate = "/xml/{id}")]
        string GetDataXML (string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/json/{id}")]
        string GetDataJSON (string id);

        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetData")]
        Response GetData (Request composite);
    }
}
