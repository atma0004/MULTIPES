using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULTIPES
    {
    class Program
        {
        static void Main(string[] args)
            {

            int runningtotal = 0;

            for (int i = 0; i<1000; i++)

                if (i%3==0||i%9==0)
                    {
                    runningtotal+=i;
                    }

            Console.WriteLine("The number is {0}" , runningtotal);
            }
        

        }
    }
