using System;
using System.Runtime.Serialization;

namespace BandD.Logger.Class
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class LogHelp
    {
        [DataMember]
        public string AplicationName { get; set; }
        [DataMember]
        public string ClientName { get; set; }
        [DataMember]
        public string MethodNameExeption { get; set; }
        [DataMember]
        public string MethodNameCode { get; set; }
        [DataMember]
        public string ExeptionMessage { get; set; }
    }
}