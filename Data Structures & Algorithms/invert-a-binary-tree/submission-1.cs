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
        Stack<TreeNode> nodeStack = new Stack<TreeNode>();
        
        nodeStack.Push(root);

        while(nodeStack.Count > 0){
            TreeNode currentNode = nodeStack.Pop();

            TreeNode? oldLeft = currentNode.left ?? null;
            currentNode.left = currentNode.right ?? null;
            currentNode.right = oldLeft;

            if(currentNode.left != null){
                nodeStack.Push(currentNode.left);
            }
            if(currentNode.right != null){
                nodeStack.Push(currentNode.right);
            }
        }

        return root;
    }
}
