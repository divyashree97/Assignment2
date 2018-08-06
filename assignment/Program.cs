using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                usertrail u = new usertrail();
                u.show();
                u.calculate();
            }
            catch(EXCEPTIONHANDLING ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
