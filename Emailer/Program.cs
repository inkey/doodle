using EmailProvider;
using EmailProvider.EmailImpl;

namespace Emailer
{
    class Program
    {
        private static EmailInfo emailInfo;
        static void Main(string[] args)
        {
            GetEmailInfo();

            IEmailService objEmail;

            //objEmail = new SMTPProvider();
            objEmail = new AmazonProvider();

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
