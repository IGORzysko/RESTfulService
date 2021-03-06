﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTClient
{
    public class RESTServiceXml : IRESTServiceXml
    {
        public string GetDataId (string id)
        {
            try
            {
                // implement logic here ...

                return string.Format($"You entered: {id}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Response GetData (Request request)
        {
            try
            {
                // implement logic here ...

                return new Response();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
