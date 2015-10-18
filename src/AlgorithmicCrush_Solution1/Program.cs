using System;

/* 
    O(n) solution
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
        for (long i = 0; i < m; i++)
        {
            string[] nextLine = Console.ReadLine().Split(' ');
            long a = long.Parse(nextLine[0]) - 1;
            long b = long.Parse(nextLine[1]);
            long k = long.Parse(nextLine[2]);

            array[a] += k;

            if (b < n)
                array[b] -= k;
        }

        long x = 0, answer = 0;
        for (long i = 0; i < n; i++)
        {
            x = x + array[i];

            if (answer < x)
                answer = x;
        }

        Console.WriteLine(answer);
        Console.ReadKey();
    }
}