using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Multidimensional
    {
        public void twoD()
        {
            int[,] a = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //foreach (int i in a)
            //{
            //    Console.Write($"{i} ");
            //}
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for(int j= 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void threeD()
        {
            int[,,] a = { { { 33, 43 }, { 3, 4 } }, { { 5, 6 }, { 8, 9 } } };
            DisplayArray(a);
            //Foreach loop
            //foreach(int i in a)
            //{
            //    Console.Write($"{i} ");
            //}

        }
        public void DisplayArray(int[,,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        Console.Write("Elemet({0},{1},{2})={3}",i,j,k,a[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
        public void Jaggedarray()
        {

            int[][] arr =
            {
               new int[] {1,2,3 },
                new int[]{4,5 },
                new int[]{6}
            };

            for(int i =0; i < arr.Length; i++)
            {
                Console.Write("Elements{0} : ",i);
                for(int j=0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "":" ") ;
                }
                Console.WriteLine() ;
            }
            
                
        }
        public void Jaggedarray2()
        {
            int[][,] arr =
            {
                new int[,] {{1,2},{4,5}, {6,7} },
                new int[,] {{2,3}, { 3,4} }
            };
            for(int i=0; i < arr.Length; i++)
            {
                Console.Write($"Elements{i}: ");
                for(int j=0;j< arr[i].GetLength(0); j++) 
                {
                    for (int k = 0; k < arr[i].GetLength(1); k++)
                        Console.Write($"{arr[i][j, k]} ");
                }
                Console.WriteLine() ;
            }
            Console.WriteLine();
        }
    }
}
