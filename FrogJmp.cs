/*
        Task: https://codility.com/programmers/task/frog_jmp/
        FrogJmp: Count minimal number of jumps from position X to Y.  
        */
        public static int FrogJmp(int X, int Y, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            return (int)Math.Ceiling((Y - X + 0.0) / D);
            
        }