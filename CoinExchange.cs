/*
        Coin exchange problem: Array A contains the coins we have, find the minum number of coins sum up to S
        DP problem
        */
        public static int CoinExchange(int[] A, int S)
        {
            int[][] result = new int[A.Length][];

            for (int i = 0; i <= S; i++)
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j] == 1) // the first coin is 1, to make sure the sub-problem solvable
                        result[j][i] = i;
                    else
                        result[j][i] = 0;
                }

            for (int j = 1; j < A.Length; j++)
                for (int i = 1; i <= S; i++)
                {
                    if (A[j] <= i)
                        result[j][i] = Math.Min(result[j - 1][i], 1 + result[j][i - A[j]]);
                    else
                        result[j][i] = result[j - 1][i];
                }

            return result[A.Length][S];
        }

        // Use one dimention array instead of two dimention array
        public static int CoinExchange1(int[] A, int S)
        {
            int[] result = new int[S + 1];

            int[] coins = new int[S + 1];

            for (int i = 0; i <= S; i++)
                result[i] = i;

            for (int i = 1; i <= S; i++)
                for (int j = 1; j < A.Length; j++)
                {
                    if (A[j] <= i)
                    {
                        int tmp;
                        // result[i] = Math.Min(1 + result[i - A[j]], result[i]);
                        tmp = 1 + result[i - A[j]];
                        if (tmp < result[i])
                        {
                            result[i] = tmp;
                            coins[i] = A[j];
                        }
                    }
                }

            // print out the coins combination
            int k = S;
            while (k > 0)
            {
                Console.WriteLine(coins[k]);
                k -= coins[k];
            }

            return result[S];
        }