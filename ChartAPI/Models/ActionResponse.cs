using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Net;

namespace Chart.API.Models
{
    [DataContract]
    public class ActionResponse
    {
        [DataMember]
        public bool Success { get; set; }

        protected List<Response> messages;

        [DataMember]
        public IList<Response> Messages { get { return messages; } }

        public ActionResponse()
        {
            messages = new List<Response>();
        }

        public void AddMessage(HttpStatusCode code, string message)
        {
            Messages.Add(new Response { StatusCode = code, Message = message });
        }
    }

    public class Response
    {
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}