using System;

namespace Solution
{
    class Program
    {
        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            // a: apple tree
            int totalApple = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                int distance = a + apples[i];
                if (distance >= s && distance <= t)
                    totalApple++;
            }

            // b: orange tree
            int totalOranges = 0;
            for (int i = 0; i < oranges.Length; i++)
            {
                int distance = b + oranges[i];
                if (distance >= s && distance <= t)
                    totalOranges++;
            }

            Console.WriteLine(totalApple);
            Console.WriteLine(totalOranges);
        }
        static void Main(string[] args)
        {
            string[] st = "7 11".Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = "5 15".Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = "3 2".Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll("-2 2 1".Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll("5 -6".Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);

        }
    }
}
