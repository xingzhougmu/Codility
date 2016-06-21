  /*
     Task: https://codility.com/programmers/task/missing_integer/
     MissingInteger: Find the minimal positive integer not occurring in a given sequence. 
     given a non-empty zero-indexed array A of N integers, returns the minimal positive integer (greater than 0) that does not occur in A.
     */
        public int MissingInteger(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            HashSet<int> hs = new HashSet<int>();

            int num = 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                    hs.Add(A[i]);
                while (hs.Contains(num))
                    num++;
            }
            return num;
        }