/*
            Task: https://codility.com/programmers/task/count_div/
            CountDiv: Compute number of integers divisible by k in range [a..b]. 
           */
        public static int CountDiv(int A, int B, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int upper = B / K;
            int lower = A / K;

            return A % K == 0 ? upper - lower + 1 : upper - lower; // take care of the most left number
        }