/*
       Task: https://codility.com/programmers/task/odd_occurrences_in_array/
       OddOccurrencesInArray: Find value that occurs in odd number of elements. 
       */
        public static int OddOccurrencesInArray(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 1)
                return A[0];

            Hashtable ht = new Hashtable();

            foreach (int i in A)
            {
                if (!ht.Contains(i))
                    ht.Add(i, 0);
                else
                    ht.Remove(i);
            }

            
            ht.Keys.CopyTo(A,0);

            return A[0];
        }