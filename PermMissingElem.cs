 /*
       Task: https://codility.com/programmers/task/perm_missing_elem/
       PermMissingElem: Find the missing element in a given permutation.  
       */
        public static int PermMissingElem(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //int sum = A.Sum();

            int sum = 0;

            for (int i = 0; i < A.Length; i++) 
            {
                sum += (A[i] - (i + 1));
            }

            sum -= (A.Length + 1);

            return Math.Abs(sum);
        }