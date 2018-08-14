using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopIntro
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculate factorial of: (enter a number >= 0)");
            int n = Convert.ToInt16(Console.ReadLine());
             
            int init = 1;
            int init2 = n;
            int nFactorial = n;
            while ( init < n )
            {
                nFactorial = nFactorial * (n - init++);
            }
            Console.WriteLine(n + " factorial, with simple while loop: " + nFactorial);

            // following code from Wikipedia
            int nFactorial2 = 1;
            do {
                nFactorial2 *= init2--;
            }
            while (init2 > 0);
            Console.WriteLine(n + " factorial, with do while loop: " + nFactorial);



        }
    }
}
