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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null){
            return true;
        };
        if((p == null) != (q == null)){
            return false;
        }
        
        Stack<(TreeNode pNode, TreeNode qNode)> nodeStack = new Stack<(TreeNode pNode, TreeNode qNode)>();

        nodeStack.Push((p, q));

        while(nodeStack.Count > 0){
            (TreeNode pNode, TreeNode qNode) currentNodes = nodeStack.Pop();
            var pNode = currentNodes.pNode;
            var qNode = currentNodes.qNode;

            if(pNode.val != qNode.val){
                return false;
            }
            if((pNode.left == null) != (qNode.left == null)){
                return false;
            }
            if((pNode.right == null) != (qNode.right == null)){
                return false;
            }

            if(pNode.right != null && qNode.right != null){
                nodeStack.Push((pNode.right, qNode.right));
            }
            if(pNode.left != null && qNode.left != null){
                nodeStack.Push((pNode.left, qNode.left));
            }
        }

        return true;
    }
}
