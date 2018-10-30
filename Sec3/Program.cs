using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec3
{
    class Program
    {
        public const double acc = 10;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите длину сообщения");

            int amount = Convert.ToInt32(Console.ReadLine());
            double p;
            double q;
            double He=0;
            double Hh = 0;

            for (int i = 1; i <= amount; i++)
            {
                p = Chance(i);
                q = 1 - p;
                He = (-1) * (p * Math.Log(p, 2) + (q * Math.Log(q, 2)));
                Hh = (-1) * (q * Math.Log(q, 2));
                Console.WriteLine("p=" + p + "\n Потерю информации на каждый символ переданного сообщения:" + He +"бит"+ "\nЭффективная энтропия алфавита = " + (1-He)+" бит\n");

            }
            Console.WriteLine(He);
        }

      public static double Chance(int amount)
        {

            return (amount / acc);
        }
    }
}
