using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single dimensional array
            int[] arr = new int[5];
            string[] week = ["sun", "mon", "tues", "wed", "thu"];
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
