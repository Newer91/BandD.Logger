using BandD.Logger.Class;
using System;
using System.Net;
using System.Net.Mail;

namespace BandD.Logger.Service
{
    public class MailService
    {
        internal void SendEmail(LogHelp log)
        {
            var fromAddress = new MailAddress("from@gmail.com", "Logger Aplication");

            const string fromPassword = "fromPassword";

            var smtp = new SmtpClient
            {
                //TODO
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = prepareMailMessage(log, fromAddress))
            {
                smtp.Send(message);
            }
        }

        private MailMessage prepareMailMessage(LogHelp log, MailAddress fromAddress)
        {
            var toAddress = new MailAddress("lisu1991@gmail.com", "Bartosz Lisowski");

            string subject = string.Format("Błąd w aplikacji {0} u klienta {1}.", log.AplicationName, log.ClientName);
            string body = prepareMessage(log.Exeption, log.MethodName);

            return new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body };
        }

        private string prepareMessage(Exception exeption, string methodName)
        {
            string result = string.Format("Wystąpił błąd w metodzie {0}. Treść błędu:" + Environment.NewLine + exeption.Message, methodName);

            return result;
        }
    }
}