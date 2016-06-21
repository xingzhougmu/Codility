/*
        Task: https://codility.com/programmers/task/cyclic_rotation/
        CyclicRotation : Rotate an array to the right by a given number of steps. 
        */
        public int[] CyclicRotation(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            // test extreme cases
            if (A.Length == 0 || A.Length == 1 || K == 0 || K == A.Length)
                return A;

            K = K % A.Length;

            int[] result = new int[A.Length];

            LinkedList<int> list = new LinkedList<int>();

            for (int i = A.Length - 1; i >= A.Length - K; i--)
            {
                list.AddFirst(A[i]);
            }

            for (int i = 0; i < A.Length - K; i++)
                list.AddLast(A[i]);

            list.CopyTo(result, 0);
            return result;

        }