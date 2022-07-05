using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegestrationWithUTestException
{
    public class UserRegistrationException : Exception
    {

        public enum ExceptionType
        {
            Empty_Message,
            NULL_Message
            //EMPTY_FIRSTNAME,
            //INVALID_FIRSTNAME,
            ////EMPTY_LASTNAME,
            //INVALID_LASTNAME,
            ////EMPTY_EMAIL_ID,
            //INVALID_EmailId,
            ////EMPTY_PASSWORD,
            //INVALID_PASSWORD,
            ////EMPTY_MOBILE_NO,
            //INVALID_MOBILE_NO
        }
        private readonly ExceptionType type;

            public UserRegistrationException(ExceptionType Type, String message) : base(message)
            {
                this.type = Type;
            }
        }
}

