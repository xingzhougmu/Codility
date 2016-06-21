 /*
       Task: https://codility.com/programmers/task/perm_missing_elem/
       FrogRiverOne: Find the earliest time when a frog can jump to the other side of a river.  
       */
        public static int FrogRiverOne(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length < X || A == null)
                return -1;

            HashSet <int> hs = new HashSet<int>();
            for (int i = 1; i <= X; i++)
            {
                hs.Add(i);
            }

            int count = 0;
            while (hs.Count > 0 && count < A.Length)
            {
                if (hs.Contains(A[count]))
                    hs.Remove(A[count]);

                count++;
            }

            if (hs.Count == 0)
                return (count - 1);
            else
                return -1;
        }