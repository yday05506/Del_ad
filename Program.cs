using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Del_ad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread threadA = new Thread(ThesMethod);
            Thread threadB = new Thread(delegate ()
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("B");
                }
            });

            Thread threadC = new Thread(delegate ()
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("C");
                }
            });

            threadA.Start();
            threadB.Start();
            threadC.Start();
        }

        private static void ThesMethod()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("A");
            }
        }
    }
}
