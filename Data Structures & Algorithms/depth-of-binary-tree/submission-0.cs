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
    public int MaxDepth(TreeNode root) {
        if(root == null){
            return 0;
        }
        
        int maxDepth = 0;

        Stack<(TreeNode node, int depth)> trackerStack = new Stack<(TreeNode node, int depth)>();
        
        trackerStack.Push((root, 1));

        while(trackerStack.Count > 0){
            (TreeNode node, int depth) tracker = trackerStack.Pop();

            if(tracker.node.left == null && tracker.node.right == null){
                maxDepth = Math.Max(maxDepth, tracker.depth);
            }

            if(tracker.node.left != null) {
                trackerStack.Push((tracker.node.left, tracker.depth + 1));
            }
            if(tracker.node.right != null) {
                trackerStack.Push((tracker.node.right, tracker.depth + 1));
            }
        }

        return maxDepth;
    }
}
