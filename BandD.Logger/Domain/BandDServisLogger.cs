using System;

namespace BandD.Logger.Domain
{
    public class BandDServisLogger
    {
        public Guid ServisLoggerId { get; set; }
        public DateTime Date { get; set; }
        public int Number { get; set; }
        public string ErrorMessage { get; set; }
        public string MethodsNameExeption { get; set; }
        public string MethodsNameCode { get; set; }
        public string Client { get; set; }
    }
}