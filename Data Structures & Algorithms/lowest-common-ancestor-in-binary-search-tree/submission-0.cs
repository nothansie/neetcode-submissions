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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        TreeNode currentNode = root;
        while(true){
            if(p.val < currentNode.val && q.val < currentNode.val){
                currentNode = currentNode.left;
            } else if(p.val > currentNode.val && q.val > currentNode.val) {
                currentNode = currentNode.right;
            } else {
                return currentNode;
            }
        }
    }
}
