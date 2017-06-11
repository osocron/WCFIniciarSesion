using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace InicioSesion.Entities.WebResults
{
    [DataContract]
    public class ServiceResponse
    {
        [DataMember]
        public bool Error { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}