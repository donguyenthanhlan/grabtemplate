using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using GrabTemplate.Common.Misc;
using GrabTemplate.Models;

namespace GrabTemplate.Misc.Helper
{
    public static class EmailHelper
    {
        public static bool Send(string toEmail, EmailTemplateViewModel template)
        {
            try
            {
                var smtp = new SmtpClient();
                smtp.Host = Constant.SMTP.Host;
                smtp.Port = Constant.SMTP.Port;
                smtp.EnableSsl = Constant.SMTP.IsSSLEnable;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential(Constant.SMTP.Username, Constant.SMTP.Password);

                using (var message = new MailMessage())
                {
                    message.From = new MailAddress(Constant.SMTP.From);
                    message.To.Add(new MailAddress(toEmail));
                    message.Bcc.Add(new MailAddress(Constant.SMTP.From));
                    message.Subject = template.Subject;
                    message.Body = template.Body;
                    message.IsBodyHtml = true;
                    message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;//– This is for set delivery notification mail On Failure

                    smtp.Send(message);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
