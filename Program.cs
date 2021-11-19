using business_logic.Model;

namespace business_logic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Going to send email");
            throw new Exception("create account on mail.com and then delete this throw statement");
            //write email address you created at mail.com and password
            IEmailHandler handler = new EmailHandler("********@mail.com","?????????");
            //enter email of receiver, subject and message
            handler.sendEmail("***********@?????.com","testing","hello world and mail");
        }
    }
}