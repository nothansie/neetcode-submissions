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
        
        var nodeStack = new Stack<(int depth, TreeNode node)>();
        nodeStack.Push((1, root));

        var maxDepth = 0;

        while(nodeStack.Count > 0){
            var currentNode = nodeStack.Pop();
            maxDepth = Math.Max(maxDepth, currentNode.depth);

            if(currentNode.node.left != null){
                nodeStack.Push((currentNode.depth + 1, currentNode.node.left));
            }
            if(currentNode.node.right != null){
                nodeStack.Push((currentNode.depth + 1, currentNode.node.right));
            }
        }

        return maxDepth;
    }
}
