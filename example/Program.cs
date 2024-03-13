using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 1, 2,3,4,5};
            int[] num2 = {1,4,6 };

            //1,4
            //6
            //2,3,5


            var t = num1.Except(num2).ToList(); // delete
            var t1= num2.Except(num1).ToList(); // add

            Console.ReadKey();


        }
    }
}
