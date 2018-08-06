using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class EXCEPTIONHANDLING:Exception
    {
        //int val1, val2;
        string msg;
        public EXCEPTIONHANDLING() 
       

        {
            msg = " number is less than zero";
        }
    public EXCEPTIONHANDLING(string m)
    {
        msg = m;
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
