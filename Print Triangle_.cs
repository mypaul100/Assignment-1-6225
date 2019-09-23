using System;
using System.Collections.Generic;

namespace Print_Triangle
{
    class Program
    {
        static void Main(string[] args) {
            printtriangle(20);
            
        }
        public static void printtriangle(int x) {
           List<int> numberarr = new List<int>();
            //add the number of stars each number will have into the array by decreasing n by 2 until it reachs 0
            for (int i = x; i > 0; i = i - 2) {
                numberarr.Add(i);
                 }
            //iterate Array
            for (int i = 0; i < numberarr.Count; i++)
                //
            {
                String tri = "";


                for (int j = 0; j < numberarr[i]; j++)
                {
                    tri += "*";
                }
                String space = "";


                for (int j = 0; j < i; j++)
                {
                    space += " ";
                }
                    Console.WriteLine(space + tri);
            }
        }


    }
}
