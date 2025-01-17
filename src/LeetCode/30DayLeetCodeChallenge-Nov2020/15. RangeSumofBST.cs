/*
#938 - https://leetcode.com/problems/range-sum-of-bst/
Given the root node of a binary search tree, return the sum of values of all nodes with a value in the range [low, high].

 

Example 1:


Input: root = [10,5,15,3,7,null,18], low = 7, high = 15
Output: 32
Example 2:


Input: root = [10,5,15,3,7,13,18,1,null,6], low = 6, high = 10
Output: 23
 

Constraints:

The number of nodes in the tree is in the range [1, 2 * 104].
1 <= Node.val <= 105
1 <= low <= high <= 105
All Node.val are unique.
*/

public class RangeSumofBST
{
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
    int sum = 0;
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        Solve(root, low, high);
        return sum;
    }

    private void Solve(TreeNode root, int low, int high)
    {
        if (root == null)
        {
            return;
        }

        if (root.val >= low && root.val <= high)
        {
            sum += root.val;
        }

        Solve(root.left, low, high);
        Solve(root.right, low, high);
    }
}