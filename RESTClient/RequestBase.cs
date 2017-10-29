using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTClient
{
    [DataContract]
    public class RequestBase
    {
        int id;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}