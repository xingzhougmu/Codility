  /*
     Task: https://codility.com/programmers/task/max_counters/
     MaxCounters: Calculate the values of counters after applying all alternating operations: increase counter by 1; set value of all counters to current maximum.  
     */
        public static int[] MaxCounters(int N, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int[] result = new int[N];
            for (int i = 0; i < N; i++)
                result[i] = 0;

            int resetMax = 0;
            int curMax = 0;
            for (int i = 0; i < A.Length; i++)
            {
                // if A[K] = N + 1 then operation K is max counter.
                if (A[i] > N)
                {
                    /* This will cause O(N*M)
                    int max = result.Max();
                    for (int j = 0; j < N; j++)
                        result[j] = max;
                        */
                    resetMax = curMax;
                }
                else // if A[K] = X, such that 1 = X = N, then operation K is increase(X),
                {

                    if (result[A[i] - 1] < resetMax)
                        result[A[i] - 1] = resetMax + 1;
                    else
                        result[A[i] - 1]++;

                    // get the current max
                    curMax = Math.Max(curMax, result[A[i] - 1]);
                }
            }

            // fix any lower than resetMax
            for (int i = 0; i < result.Length; i++)
                result[i] = Math.Max(result[i], resetMax);

            return result;

        }