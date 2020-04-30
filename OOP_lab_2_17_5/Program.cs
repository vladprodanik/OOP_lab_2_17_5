using System;

namespace OOP_lab_2_17_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] a = new int[n, m];

            var rand = new Random();

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    a[i, j] = rand.Next(0, 100);
                }
            }

            int maxa = a[0, 0];

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (maxa <= a[i, j]) maxa = a[i, j];
                }
            }

            int[] b = new int[maxa + 1];

            for (int i = 1; i <= maxa; ++i)
            {
                b[i] = 0;
            }
                
            int count;

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    count = 0;

                    for (int k = 0; k < n; ++k)
                    {
                        for (int l = 0; l < m; ++l)
                        {
                            if (a[i, j] == a[k, l])
                            {
                                ++count;
                            }
                        }
                    }

                    b[a[i, j]] = count;
                }
            }

            for (int i = 1; i <= maxa; ++i)
            {
                if (b[i] != 0)
                {
                    Console.WriteLine("{0} - {1}", i, b[i]);
                }
            }
        }
    }
}
