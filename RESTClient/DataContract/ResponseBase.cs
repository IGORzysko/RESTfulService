using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTClient
{
    [DataContract]
    public class ResponseBase
    {
        public ResponseBase ()
        {

        }

        int id;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                value = id;
            }
        }
    }
}