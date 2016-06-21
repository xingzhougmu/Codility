/*
        Task: https://codility.com/programmers/task/min_avg_two_slice/
        MinAvgTwoSlice: Find the minimal average of any slice containing at least two elements. 
        */
        public int MinAvgTwoSlice(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            double min_avg_value = (A[0] + A[1]) / 2.0;   // The mininal average
            int min_avg_pos = 0;     // The begin position of the first
                                     // slice with mininal average

            for (int index = 0; index < A.Length - 2; index++)
            {
                // Try the next 2-element slice
                if ((A[index] + A[index + 1]) / 2.0 < min_avg_value)
                {
                    min_avg_value = (A[index] + A[index + 1]) / 2.0;
                    min_avg_pos = index;
                }
                // Try the next 3-element slice
                if ((A[index] + A[index + 1] + A[index + 2]) / 3.0 < min_avg_value)
                {
                    min_avg_value = (A[index] + A[index + 1] + A[index + 2]) / 3.0;
                    min_avg_pos = index;
                }
            }

            // Try the last 2-element slice
            if ((A[A.Length - 1] + A[A.Length - 2]) / 2.0 < min_avg_value)
            {
                min_avg_value = (A[A.Length - 1] + A[A.Length - 2]) / 2.0;
                min_avg_pos = A.Length - 2;
            }
            return min_avg_pos;

        }