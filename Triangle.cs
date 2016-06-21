/*
        Task: https://codility.com/programmers/task/triangle/
        Triangle: Detemine whether a triangle can be built from a given set of edges. 
        */
        public int Triangle(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Array.Sort(A);

            //N^3 SOLUTION
            /*
            for (int i = 0; i < A.Length - 2; i++)
                for (int j = i + 1; j < A.Length - 1; j++)
                    for (int k = j + 1; k < A.Length; k++)
                    {
                        if (A[i] + A[j] > A[k])
                            return 1;
                    }
                    */

            for (int i = 0; i < A.Length - 2; i++)
            {
                if (A[i] + A[i+1] > A[i+2])
                    return 1;
            }

                return 0;
        }