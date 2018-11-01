using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "habr";
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            string buf = null;
            string[] bin;
            int k;
            int r;
            int n;
            for (int i = 0; i < bytes.Length; i++)
            {
                int h = Convert.ToString(bytes[i], 2).Length;
                buf += h <= 8 ? IntToBinary(h) + Convert.ToString(bytes[i], 2) + ":" : Convert.ToString(bytes[i], 2) + ":";
                
            }
            k = buf.Length;
            r = (int)Math.Log(k, 2) + 1;
            n = r + k;
            Console.WriteLine("k={0}\nr={1}\nn={2}",k,r,n);
            bin = buf.Split(':');
            foreach (var item in bin)
            {
                Console.WriteLine(item);
            }
        }

        static string IntToBinary(int a)
        {
            int b = 0;
            b = 8 - a;
            string len = null;

            for (int i = 0; i < b; i++)
            {
                len += "0";
            }
            return len;
        }

    }
}