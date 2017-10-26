using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using MonitorPingUI;

namespace MonitorPingUI
{
    [DataContract]
    public class Json
    {
        [DataMember]
        public string Hosts { get; set; }

        public Json(string hosts)
        {
            Hosts = hosts;
        }
    }
}
