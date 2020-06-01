using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ConsoleApp2
{
    class Class3
    {
        public void mail()
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            System.Net.Mail.SmtpClient smtpClient = new SmtpClient();

            //set the addresses
            mail.From = new MailAddress("xyz@gmail.com");
            mail.To.Add("");
            mail.ReplyTo = new MailAddress("xyz@gmail.com");
            //set the content
            mail.Subject = "This is an email";
            mail.Body = "body content of the email.";


            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.Delay;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.Never;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.None;

            mail.Headers.Add("Disposition-Notification-To", "xyz@gmail.com");

            smtpClient.Host = "relay-hosting.secureserver.net";
            mail.Priority = System.Net.Mail.MailPriority.High;
            smtpClient.Send(mail);

        }
    }
}
