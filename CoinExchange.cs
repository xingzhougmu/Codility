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
                    if (A[j] >= i)
                        result[j][i] = Math.Min(result[j - 1][i], 1 + result[j][i - A[j]]);
                    else
                        result[j][i] = result[j - 1][i];
                }

            return result[A.Length][S];
        }