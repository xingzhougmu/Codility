/*
        Task: https://codility.com/programmers/task/equi_leader/
        EquiLeader: Find the index S such that the leaders of the sequences A[0], A[1], ..., A[S] and A[S + 1], A[S + 2], ..., A[N - 1] are the same.
        1. leader of the two sub arrys is the leader of the whole array;
        2. Use prefix array to store the leader count of left sub array to avoid O(N^2)
        */
        public static int EquiLeader(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int leader = findLeader(A);

            if (leader == -1)
                return 0;

            int[] prefixCnt = new int[A.Length]; // Use prefix array to save leader count
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (leader == A[i])
                    count++;
                prefixCnt[i] = count;
            }

            int equl = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int leftCount = prefixCnt[i];

                if (leftCount * 2 > i + 1 && (count - leftCount) * 2 > A.Length - i - 1)
                    equl++;
            }

            return equl;
        }

        public static int findLeader(int[] A)
        {
            int size = 0;
            int leader = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (size == 0)
                    leader = A[i];
                if (A[i] != leader)
                    size--;
                else
                    size++;
            }

            if (size == 0) return -1;

            size = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == leader)
                    size++;

            }

            return size * 2 <= A.Length ? -1 : leader;
        }

        public int countLeader(int[] A, int leader)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (leader == A[i])
                    count++;
            }
            return count;
        }