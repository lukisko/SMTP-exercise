using System;
using System.Net.Mail;

namespace business_logic.Model
{
    public class EmailHandler : IEmailHandler
    {
        private string username;
        private string password;
        public EmailHandler(string username,string password){
            this.username = username;
            this.password = password;
        }
        public void sendEmail(string EmailAddress, string title, string content){
            MailMessage mail = new MailMessage();
            SmtpClient mailClient = new SmtpClient("smtp.mail.com");

            mail.From = new MailAddress("lukas.pleva@mail.com");
            mail.To.Add(EmailAddress);
            mail.Subject = title;
            mail.Body = content;

            mailClient.Port = 587;
            //throw new Exception("create account at mail.com and change email and password in next line and then delete this exeption");
            mailClient.Credentials = new System.Net.NetworkCredential(username,password);
            mailClient.EnableSsl = false;

            mailClient.Send(mail);
            mailClient.SendMailAsync(mail);
        }
        public void sendLoginLink(string EmailAddress, string LoginCode){
            this.sendEmail(EmailAddress,"login code","Hello, here you have your login code: "+LoginCode);
        }
    }
}