using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ArraysExample
    {
        //int[] numbers = {10, 20, 30};
        int[] numbers = new int[5]; //1D
        int[,] nums = new int[2,2];
        public void OneDimensional()
        {
            numbers[0] = 3;
            numbers[1] = 2;
            numbers[2] = 1;
            Console.WriteLine("One Dimensional Array:");
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            Console.WriteLine("new array:");
            numbers = new int[8];
            numbers[4] = 7;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        /////Two dimensional array
        public void TwoDimensional()
        {
            //nums[0, 0] = 100;
            //nums[0, 1] = 200;
            //nums[1, 0] = 300;
            //nums[1, 1] = 400;
            int[,] nums = { { 100, 200 }, { 300, 400 } };
            Console.WriteLine("Two Dimensional Array:");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }

        ///////Jagged Array//////
        public void JaggedArray()
        {
            int[][,] arr = new int[][,]
            {
                new int[,] {{ 100, 200 }, { 300,400} },
                new int[,] {{500,600},{700,800},{900,100}},
                new int[,] {{600,200},{400,100},{500,300}}
            };
            Console.WriteLine("Jagged Array:");
            foreach (var item in arr)
            {
                Console.WriteLine(item[0, 1]);
            }
            Console.WriteLine();
            for (int i=0; i<arr.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < arr[i].GetLength(x);j++)
                {
                    for(int k = 0; k < arr[j].Rank;k++)
                    {
                        Console.Write(arr[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine() ;
            }
        }
        
    }
}
