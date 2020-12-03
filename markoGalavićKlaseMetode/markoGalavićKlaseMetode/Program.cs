using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićKlaseMetode
{
    class Program
    {
        static void Main(string[] args)
        {
            double postotak=0;
           

            Produceralni x = new Produceralni();
            Objektni y = new Objektni();
            Funkcionalni z = new Funkcionalni();

            Console.WriteLine("Unesite postoak za Produceralni");
            postotak = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite postoak za Objektni");
            postotak = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite postoak za Funkcionalni");
            postotak = Convert.ToInt32(Console.ReadLine());

            if (postotak+postotak+postotak  > 100|| postotak + postotak + postotak < 100)
            {
                Console.WriteLine("Krivi unos ");
            }

            Console.WriteLine(":" + x);
            Console.WriteLine(":" + y);
            Console.WriteLine(":" + z);
            Console.ReadKey();
        }
    }
    }
}
