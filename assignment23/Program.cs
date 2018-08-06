using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment23
{
    class Program
    {
        static void Main(string[] args)
        {

            List<pizzaorder> po = new List<pizzaorder>
            {
                new pizzaorder {orderid=12,orderdate=DateTime.Now,pizzatype="veg",pizzasize='s',toppings="sweet corn",qty=2,prize=625 },
                new pizzaorder {orderid=13,orderdate=DateTime.Now,pizzatype=" non veg",pizzasize='m',toppings="egg",qty=2,prize=800 },

                new pizzaorder {orderid=14,orderdate=DateTime.Now,pizzatype="veg",pizzasize='l',toppings="onion",qty=1,prize=610 },

                new pizzaorder {orderid=15,orderdate=DateTime.Now,pizzatype=" non veg",pizzasize='s',toppings="chicken",qty=3,prize=700 },

                new pizzaorder {orderid=16,orderdate=DateTime.Now,pizzatype="veg",pizzasize='m',toppings="tomato",qty=4,prize=730 },
                new pizzaorder {orderid=17,orderdate=DateTime.Now,pizzatype="veg",pizzasize='s',toppings="capsicum",qty=2,prize=625 }
            };
            foreach (var r in po)
            {
                Console.WriteLine(r.orderid + " " + r.orderdate + " " + r.pizzatype + " " + r.pizzasize + "  " + r.toppings + "  " + r.qty + "  " + r.prize);

            }
            Console.WriteLine("********************");
            var data1 = po.Select(x => new
            {
                Ptype = x.pizzatype,
                Psize = x.pizzasize
            });


            foreach (var h in data1)
            {
                Console.WriteLine(h.Ptype + " " + h.Psize);
            }

            var data2 = po.GroupBy(x => x.pizzatype).Select(x => new
            {
                Ptype = x.Key,
                sumqty = x.Sum(y => y.qty),
                sumamt = x.Sum(z => z.prize)
            });

            foreach (var h in data2)
                Console.WriteLine(h.Ptype + " " + h.sumqty + " " + h.sumamt);


            var data3 = po.GroupBy(x => x.pizzasize).Select(x => new
            {
                Psize = x.Key,
                sumqty = x.Sum(y => y.qty),
                sumamt = x.Sum(z => z.prize)
            });

            foreach (var h in data3)
                Console.WriteLine(h.Psize + " " + h.sumqty + " " + h.sumamt);
            Console.WriteLine("*************************");


            var data4 = po.Where(x => x.pizzasize == 'm' || x.pizzasize == 'm').Select(x => new
            {
                Ptype = x.pizzatype,
                top = x.toppings
            });

            foreach (var h in data4)
                Console.WriteLine(h.Ptype + " " + h.top);
            Console.WriteLine("**************");

            var maxprice = po.Where(x => x.prize== po.Max(y => y.prize));
            foreach (var r in maxprice)
            {
                Console.WriteLine(r.orderid + " " + r.orderdate + " " + r.pizzatype + " " + r.pizzasize + "  " + r.toppings + "  " + r.qty + "  " + r.prize);
            }
            var minprice = po.Where(x => x.prize == po.Min(y => y.prize));
            foreach (var r in minprice)
            {
                Console.WriteLine(r.orderid + " " + r.orderdate + " " + r.pizzatype + " " + r.pizzasize + "  " + r.toppings + "  " + r.qty + "  " + r.prize);
            }







        }
    }
}
