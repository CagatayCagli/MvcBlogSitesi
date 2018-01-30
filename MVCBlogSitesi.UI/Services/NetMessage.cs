using System;
using System.Net;
using System.Net.Mail;

namespace MVCBlogSitesi.UI.Services
{
    public class NetMessage:IMessage
    {
       

        public string To { get; set; }


        public bool SendMessage(string subject, string message)
        {
            MailMessage ms = new MailMessage {From = new MailAddress("beramusko34@gmail.com")};
            ms.To.Add(To);
            ms.IsBodyHtml = true;
            ms.Body = message;
            ms.Subject = subject;

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential("beramusko34@gmail.com", "fanfb951")
            };

            try
            {
                smtp.Send(ms);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}