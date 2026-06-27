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
    public TreeNode InvertTree(TreeNode root) {
        if(root == null){
            return root;
        }
        
        var nodeStack = new Stack<TreeNode>();
        nodeStack.Push(root);

        while(nodeStack.Count > 0){
            var node = nodeStack.Pop();
            if(node.left != null){
                nodeStack.Push(node.left);
            }
            if(node.right != null){
                nodeStack.Push(node.right);
            }

            var newRight = node.left;
            node.left = node.right;
            node.right = newRight;
        }

        return root;
    }
}
