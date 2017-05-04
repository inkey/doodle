using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailer
{
    class Program
    {
        private static EmailInfo emailInfo;
        static void Main(string[] args)
        {
            GetEmailInfo();

            IEmailService objEmail;

            objEmail = new SMTPProvider();

            EmailSender objSender = new EmailSender(objEmail);
            objSender.Notification(emailInfo);

        }



        private static EmailInfo GetEmailInfo()
        {
            emailInfo = new EmailInfo();
            emailInfo.EmailTo = "Test@test.com";
            emailInfo.EmailFrom = "Test@test.com";
            emailInfo.Subject = "Test";
            emailInfo.Body = "This is a test";
            return emailInfo;
        }

    }
       


    
}
