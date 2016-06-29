/*
        Given a binary tree, find its minimum depth.
        The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
        */

        /**
         * Definition for a binary tree node.
         * public class TreeNode {
         *     public int val;
         *     public TreeNode left;
         *     public TreeNode right;
         *     public TreeNode(int x) { val = x; }
         * }
         */

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x)
            {
                val = x;
            }
        }

        public int MinDepth_recursive(TreeNode root)
        {
            if (root == null)
                return 0;
            return getMin(root);
        }

        public int getMin(TreeNode root)
        {
            if (root == null)
                return int.MaxValue;

            if (root.left == null && root.right == null)
            {
                return 1;
            }

            return Math.Min(getMin(root.left), getMin(root.right)) + 1;

        }

        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();

            // int minDepth = 1;
            root.val = 1;
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode curr = queue.Dequeue();

                if (curr.left == null && curr.right == null)
                    return curr.val;
                else
                {
                    if (curr.left != null)
                    {
                        curr.left.val = curr.val + 1;
                        queue.Enqueue(curr.left);
                    }

                    if (curr.right != null)
                    {
                        curr.right.val = curr.val + 1;
                        queue.Enqueue(curr.right);
                    }
                }
            }

            return 0;

        }