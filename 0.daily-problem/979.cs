public partial class DailyProblemSolution
{
    //  Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    int ans = 0;
    public int DistributeCoins(TreeNode root)
    {
        // switch left and right, 2 steps; switch parent and child, 1 step
        DFS(root);
        return ans;
    }

    public int DFS(TreeNode root)
    {
        if (root == null) return 0;
        int left = DFS(root.left);
        int right = DFS(root.right);
        ans += Math.Abs(left) + Math.Abs(right);
        return root.val + left + right - 1;
    }
}