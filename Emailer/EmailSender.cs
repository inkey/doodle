using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailer
{
  public  class EmailSender
    {
        //This is the most common dependency injection.
        //When a class requires an instance of a dependency to work, we can supply that dependency through the class’s constructor. 

        private IEmailService _iEmailService;
        //the implementation of the constructor is very simple 
        public EmailSender(IEmailService _mailService)
        {
            this._iEmailService = _mailService;
        }
        public void Notification(EmailInfo ObjEmailInfo)
        {
            _iEmailService.sendMail(ObjEmailInfo);
        }
    }
}
