using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment22
{
    class NoMatchException:Exception
    {
        string msg;
        public NoMatchException()
        {
            msg = "given string is not deloitte string";
        }
        public NoMatchException(string msg)
        {
            this.msg = msg;
        }
        public override string Message
        {
            get
            {
                return msg;
            }
        }


    }
}
