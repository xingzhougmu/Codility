  /*
      Task: https://codility.com/programmers/task/perm_missing_elem/
      PermCheck: Check whether array A is a permutation. 
      A permutation is a sequence containing each element from 1 to N once, and only once. 
      */
        public static int PermCheck(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            // check total sum and uniqueness
            HashSet<int> hs = new HashSet<int>();
            int result = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (hs.Contains(A[i]))
                    return 0;
                else
                    hs.Add(A[i]);

                result += A[i] - (i + 1);
            }

            return result == 0 ? 1 : 0;
        }