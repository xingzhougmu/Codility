 /*
        Task:https://codility.com/programmers/task/distinct/
        Distinct: Compute number of distinct values in an array. 
        */
        public int Distinct(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            HashSet<int> hs = new HashSet<int>();

            int count = 0;
            foreach (var item in A)
            {
                if (!hs.Contains(item))
                {
                    hs.Add(item);
                    count++;
                }
            }
            return count;
        }