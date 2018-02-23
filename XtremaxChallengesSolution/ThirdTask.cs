﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtremaxChallengesSolution
{
    public class ThirdTask
    {
        public static int solution(int[] A, int X)
        {
            int N = A.Length;
            if (N == 0)
            {
                return (-1);
            }

            int l = 0;
            int r = N - 1;
            while (l < r)
            {
                int m = (l + r) / 2;
                if (A[m] > X)
                {
                    r = m - 1;
                }
                else
                {
                    l = m;
                }
            }

            if (A[l] == X)
            {
                return l;
            }

            return -1;
        }

        static void Main(string[] args)
        {

            Console.WriteLine($"Answer : {solution(new[] { 1, 2, 5, 9, 9 }, 5)}");

            Console.ReadKey();

        }
    }
}
