/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        var nodeStack = new Stack<TreeNode>();
        var current = root;

        var count = 1;
        while(current != null || nodeStack.Count > 0){
            while(current != null){
                nodeStack.Push(current);
                current = current.left;
            }

            current = nodeStack.Pop();
            if(count == k){
                return current.val;
            }
            current = current.right;
            count++;
        }

        return current.val;
    }
}
