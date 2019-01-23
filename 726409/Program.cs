using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _726409
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 2;
            while(i<=7)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("{0}",sum);
        }
    }
}
