/*
        Task: https://codility.com/programmers/task/genomic_range_query/
        GenomicRangeQuery: Find the minimal nucleotide from a range of sequence DNA. 
        */
        public static int[] GenomicRangeQuery(string S, int[] P, int[] Q)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var nucleo = new int[S.Length + 1, 4];

            for (var count = 0; count < S.Length; count++)

            {

                if (count > 0)

                {

                    for (var index = 0; index < 4; index++)

                    {

                        nucleo[count + 1, index] += nucleo[count, index];

                    }

                }




                switch (S[count])

                {

                    case 'A':

                        nucleo[count + 1, 0]++;

                        break;

                    case 'C':

                        nucleo[count + 1, 1]++;

                        break;

                    case 'G':

                        nucleo[count + 1, 2]++;

                        break;

                    case 'T':

                        nucleo[count + 1, 3]++;

                        break;

                }

            }




            var result = new int[P.Length];

            for (var count = 0; count < P.Length; count++)
            {

                if (P[count] == Q[count])

                {

                    switch (S[P[count]])
                    {

                        case 'A':

                            result[count] = 1;

                            break;

                        case 'C':

                            result[count] = 2;

                            break;

                        case 'G':

                            result[count] = 3;

                            break;

                        case 'T':

                            result[count] = 4;

                            break;

                    }

                }
                else
                {

                    for (var index = 0; index < 4; index++)
                    {

                        if ((nucleo[Q[count] + 1, index] - nucleo[P[count], index]) > 0)
                        {

                            result[count] = index + 1;

                            break;

                        }

                    }

                }

            }




            return result;
            /* 100% Corretness, but 0 performance
            int[] result = new int[P.Length];

            for (int i = 0; i < P.Length; i++)
            {
                string tmp = S.Substring(P[i], Q[i] - P[i] + 1);
                if (tmp == null)
                {
                    result[i] = 0;
                    continue;
                }
                if (tmp.Contains('A'))
                {
                    result[i] = 1;
                    continue;
                }
                else if (tmp.Contains('C'))
                {
                    result[i] = 2;
                    continue;
                }
                else if (tmp.Contains('G'))
                {
                    result[i] = 3;
                    continue;
                }
                else
                    result[i] = 4;
            }

            return result;
            */
        }