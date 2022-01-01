using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAgregate a = new ConcreteAgregate();
            a[0]=  "item a";
            a[1] = "item b";
            a[2] = "item c";
            a[3] = "item d";
            Iterator b = a.create();
            Console.WriteLine("over collection:");
            object item = b.first();
            while(item!=null)
            {
                Console.WriteLine(item);
                item = b.next();
            }
            Console.ReadKey();

        }
    }
}
