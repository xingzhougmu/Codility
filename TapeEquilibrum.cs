 /*
        Task: https://codility.com/programmers/task/tape_equilibrium/
        TapeEquilibrium: Minimize the value |(A[0] + ... + A[P - 1]) - (A[P] + ... + A[N - 1])|.   
        */
        public static int TapeEquilibrium(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //calculate sum table
            int tmp = 0;
            for (int i=0; i<A.Length;i++)
            {
                tmp += A[i];
                A[i] = tmp;
            }

            int result = Int32.MaxValue;
            for (int i=0;i<A.Length-1;i++)
            {
                tmp = Math.Abs(A[A.Length - 1] - A[i] * 2);

                if (tmp < result)
                    result = tmp;
            }

            //int result = Int32.MaxValue;
            //for (int k=1;k<A.Length;k++)
            //{
            //    int tmp = sumDiff(A, k);
            //    if (tmp < result)
            //        result = tmp;
            //}
            return result;
        }

        public static int sumDiff(int[] A, int k)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int result = 0;
            for (int i=0; i<A.Length;i++)
            {
                if (i < k)
                    result += A[i];
                else
                    result -= A[i];
            }
            return Math.Abs(result);
        }