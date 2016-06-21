/*
        Task: https://codility.com/programmers/task/max_product_of_three/
        MaxProductOfThree: Maximize A[P] * A[Q] * A[R] for any triplet (P, Q, R). 
        */
        public int MaxProductOfThree(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length < 3)
                return 0;

            if (A.Length == 3)
                return A[0] * A[1] * A[2];

            Array.Sort(A);

            if (A[0] >= 0 || A[A.Length - 1] < 0)
                return A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
            else
                return A[0] * A[1] > 0 ? Math.Max(A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3], A[0] * A[1] * A[A.Length - 1]) : A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];

        }