using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment22
{
    class acceptstring
    {

        public void inputstring()
        {
            Console.WriteLine("enter the string");
            string st = Console.ReadLine();
            string sr = "deloitte training";
            int result = string.Compare(st, sr);
            if (result != 0)
            {
                throw new NoMatchException();
                
            }
            else
            {
                Console.WriteLine("string matches");
            }
           
        }
    }
}

