/*
        Task: https://codility.com/programmers/task/binary_gap/
                BinaryGap: Find longest sequence of zeros in binary representation of an integer. 
        */
        public int BinaryGap (int N)
        {
            string bits = Convert.ToString(N, 2);
            // Console.WriteLine(bits);
            string[] gaps = bits.Split('1');

            // the last string in gaps is either empty or 0s-- Set whatever to empty
            gaps[gaps.Length - 1] = string.Empty;

            int max = 0;
            foreach (string s in gaps)
            {
                
                // Console.WriteLine(s);
                if (s.Length > max)
                    max = s.Length;
            }

            return max;
        }