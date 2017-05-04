using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailer
{
  public  class EmailSender
    {
        private EmailProvider.IEmailService _iEmailService;
        //the implementation of the constructor is very simple 
        public EmailSender(EmailProvider.IEmailService _mailService)
        {
            this._iEmailService = _mailService;
        }
        public void Notification(EmailProvider.EmailInfo ObjEmailInfo)
        {
            _iEmailService.sendMail(ObjEmailInfo);
        }
    }
}
