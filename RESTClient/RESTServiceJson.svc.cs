using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTClient
{
    public class RESTServiceJson : IRESTServiceJson
    {
        public string GetData (string id)
        {
            try
            {
                // implement logic here ...

                return string.Format("You entered: {0}", id);
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
