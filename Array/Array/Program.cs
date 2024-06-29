using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single dimensional array
            //int[] arry = new int[5];
            //int[] arr = {1,2,3,4,5};

            //string[] week = { "sun", "mon", "tues", "wed", "thu" };
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(week[0]);
            //Console.ReadKey();
            Multidimensional obj = new Multidimensional();
            obj.twoD();
            //obj.threeD();
            //obj.Jaggedarray2();
            Console.ReadKey();
        }
    }
}
