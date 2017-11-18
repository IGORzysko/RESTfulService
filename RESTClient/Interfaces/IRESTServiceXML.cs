﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTClient
{
    [ServiceContract]
    public interface IRESTServiceXml
    {
        [OperationContract]
        [WebInvoke(Method = "GET",           
            BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Xml, 
            UriTemplate = "/{id}")]
        string GetDataId (string id);

        [OperationContract] 
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Xml,
            ResponseFormat = WebMessageFormat.Xml,
            UriTemplate = "/GetData")]
        Response GetData(Request request);
    }
}
