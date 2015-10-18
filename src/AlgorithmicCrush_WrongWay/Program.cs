using System;

/* 
    O(n^2) solution
    https://www.hackerrank.com/challenges/crush
*/

class Solution
{
    static void Main()
    {
        string[] line1 = Console.ReadLine().Split(' ');
        long n = long.Parse(line1[0]);
        long m = long.Parse(line1[1]);

        long[] array = new long[n];
        long answer = 0;
        for (int i = 0; i < m; i++)
        {
            string[] nextLine = Console.ReadLine().Split(' ');
            long a = long.Parse(nextLine[0]);
            long b = long.Parse(nextLine[1]);
            long k = long.Parse(nextLine[2]);

            for (long j = a - 1; j < b; j++)
            {
                array[j] += k;

                if (array[j] > answer)
                    answer = array[j];
            }
        }
        
        Console.WriteLine(answer);
    }
}