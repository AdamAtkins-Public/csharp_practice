using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * An irrational decimal fraction is created by concatenating the positive integers:
 *
 * 0.123456789101112131415161718192021...
 *
 * It can be seen that the 12th digit of the fractional part is 1.
 *
 * If dn represents the nth digit of the fractional part, find the value of the following expression.
 *
 * d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000
 */
namespace csharp_practice.project_euler
{
    class P040
    {
        public P040()
        {
        }
        //Champernowne's constant
        private static string ChampernownesConstant(int limit)
        {
            StringBuilder d = new StringBuilder();
            int digit = 1;
            while(d.Length < limit)
            {
                d.Append(digit.ToString());
                digit++;
            }
            return d.ToString();
        }
        public void Solution()
        {
            Stopwatch time = Stopwatch.StartNew();
            string Cconstant = ChampernownesConstant(1000000);
            int value = 1;
            for(int i = 0; i < 7; i++)
            {
                value *= Int32.Parse(Cconstant.ElementAt((int)Math.Pow(10, i)-1).ToString());
            }
            time.Stop();
            Console.WriteLine(String.Format("Value: {0}\nRuntime: {1}ms", value, time.ElapsedMilliseconds));
        }
    }
}
