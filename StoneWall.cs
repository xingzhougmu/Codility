/*
        Task: https://codility.com/programmers/task/stone_wall/
        StoneWall: Cover "Manhattan skyline" using the minimum number of rectangles.
        // Cover "Manhattan skyline" using the minimum number of rectangles.
        // https://briangordon.github.io/2014/08/the-skyline-problem.html
        */
        public static int StoneWall(int[] H)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int num = 0;

            Stack<int> st = new Stack<int>();

            for (int i = 0; i < H.Length; i++)
            {
                while (st.Count > 0 && st.Peek() > H[i])
                    st.Pop();

                if (st.Count > 0 && st.Peek() == H[i])
                    continue;
                else
                {
                    num++;
                    st.Push(H[i]);
                }
            }
                return num;
            /*
            if (H.Length == 1)
                return 1;

            Queue<int> q = new Queue<int>();

            for (int i = 0; i < H.Length; i++)
                q.Enqueue(H[i]);

            int num = 0;

            int curr = q.Dequeue();
            while (q.Count > 0)
            {
                if (curr == q.Peek())
                {
                    curr = q.Dequeue();
                }
                else if (curr > q.Peek())
                {
                    num++;
                    curr = q.Dequeue();
                    q.Enqueue(0);
                }
                else
                {
                    if (curr == 0)
                    {
                        curr = q.Peek();
                    }
                    else
                    {
                        q.Enqueue(q.Peek() - curr);
                        q.Dequeue();                        
                    }
                }
            }

            return num;
            */
    }