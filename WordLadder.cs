/*
        Given two words (start and end), and a dictionary, find the length of shortest transformation sequence from start to end, such that only one letter can be changed at a time and each intermediate word must exist in the dictionary. For example, given:
        One shortest transformation is "hit" -> "hot" -> "dot" -> "dog" -> "cog", the program should return its length 5.
        Breadth-first search
        */

         class WordNode
        {
            public string word;
            public int numSteps;

            public WordNode(string word, int numSteps)
            {
                this.word = word;
                this.numSteps = numSteps;
            }
        }

        public static int ladderLength(string beginWord, string endWord, ISet<string> wordDict)
        {
            Stack<WordNode> stack = new Stack<WordNode>();

            stack.Push(new WordNode(beginWord, 1));

            wordDict.Add(endWord);

            while (stack.Count > 0)
            {
                WordNode top = stack.Pop();

                string word = top.word;

                if (word.Equals(endWord))
                    return top.numSteps;

                char[] arr = word.ToCharArray();
                for (int i = 0; i < word.Length; i++)
                {
                    char tmp = arr[i];
                    for (char c = 'a'; c < 'z'; c++)
                    {
                        // if (arr[i] != c)
                        arr[i] = c;

                        string newWord = new string(arr);
                        if (wordDict.Contains(newWord))
                        {
                            stack.Push(new WordNode(newWord, top.numSteps + 1));
                            wordDict.Remove(newWord);
                        }

                        // arr[i] = tmp;
                    }
                    arr[i] = tmp;
                }


            }

            return 0;
        }