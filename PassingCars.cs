/*
        Task: https://codility.com/programmers/task/passing_cars/
        PassingCars: Count  the number of passing cars on the road.
        The goal is to count passing cars. We say that a pair of cars (P, Q), where 0 = P < Q < N, is passing when P is traveling to the east and Q is traveling to the west.   
       */
        public int PassingCars(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            // convert int arry to string
            string s = A.ToString();
            s = string.Join("", A.Select(i => i.ToString()).ToArray());

            int result = 0;
            int duplicate = 0;
            for (int i=0;i<s.Length;i++)
            {
                if (s[i]=='1')
                {
                    result += i - duplicate;
                    duplicate++;

                    // The function should return -1 if the number of pairs of passing cars exceeds 1,000,000,000.
                    if (result > 1000000000)
                        return -1;
                }
            }

            return result;
        }