using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment22
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                acceptstring a = new acceptstring();
                a.inputstring();
            }
            catch(NoMatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
