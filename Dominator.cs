/*
        Task: https://codility.com/programmers/task/dominator/
        Dominator: Find an index of an array such that its value occurs at more than half of indices in the array. 
        //Find an index of an array such that its value occurs at more than half of indices in the array. 
        */
        public int Dominator(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
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
            int index = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == leader)
                {
                    size++;
                    index = i;
                }

            }

            return size * 2 <= A.Length ? -1 : index;
        }