﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
        //public static void SendEmail(string to, string subject, string body)
        //{
        //    MailAddress fromMailAdress = new MailAddress(GlobalConfig.AppKeyLookup("senderEmail"), GlobalConfig.AppKeyLookup("senderDisplayName"));

        //    MailMessage mail = new MailMessage();

        //    mail.To.Add(to);
        //    mail.From = fromMailAdress;
        //    mail.Subject = subject;
        //    mail.Body = body;
        //    mail.IsBodyHtml = true;

        //    SmtpClient client = new SmtpClient();

        //    client.Send(mail);
        //}
    }
}
