using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arry___Class_ghomework
{
    internal class Factorial
    {
        public void Num(int n)
           
        {
           int multiple = 1;
            for (int i = 1; i <= n; i++)
            {
                multiple *= i;
            }
             Console.WriteLine(multiple);

        }




    }
        
}
