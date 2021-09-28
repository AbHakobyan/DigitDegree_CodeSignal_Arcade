using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitDegree_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 99;
            int x = digitDegree(n);
            Console.WriteLine(x);
        }

        static int digitDegree(int n)
        {
            string st = n.ToString();
            int sum = 0;
            int count = 0;
            List<string> list = new List<string>();
            if (st.Length == 1)
            {
                return 0;
            }
            while (st.Length > 1)
            {
                for (int i = 0; i < st.Length; i++)
                {
                    sum += Convert.ToInt32(st[i].ToString());
                }
                st = sum.ToString();
                sum = 0;
                count++;
            }
            return count;
        }
    }
}
