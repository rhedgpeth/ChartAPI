using System.Runtime.Serialization;

namespace Chart.API.Models
{
    [DataContract]
    public class DataResponse<T> : ActionResponse
    {
        [DataMember]
        public T Data { get; set; }
    }
}