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
    public bool IsValidBST(TreeNode root) {
        var nodeStack = new Stack<(int min, int max, TreeNode node)>();

        nodeStack.Push((Int32.MinValue, Int32.MaxValue, root));

        while(nodeStack.Count > 0){
            var currentNode = nodeStack.Pop();
            if(currentNode.min < currentNode.node.val && currentNode.node.val < currentNode.max){
                if(currentNode.node.left != null){
                    nodeStack.Push((currentNode.min, currentNode.node.val, currentNode.node.left));
                }
                if(currentNode.node.right != null){
                    nodeStack.Push((currentNode.node.val, currentNode.max, currentNode.node.right));
                }
            } else {
                return false;
            }
        }

        return true;
    }
}
