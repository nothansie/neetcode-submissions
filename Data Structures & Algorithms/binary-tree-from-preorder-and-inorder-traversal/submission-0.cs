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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if(preorder.Length <= 0 || inorder.Length <= 0){
            return null;
        }
        var rootNode = new TreeNode(preorder[0], null, null);
        if(preorder.Length == 1 || inorder.Length == 1){
            return rootNode;
        }
        var i = 0;
        while(inorder[i] != rootNode.val){
            i++;
        }
        rootNode.left = BuildTree(preorder[1..(i+1)],inorder[0..i]);
        rootNode.right = BuildTree(preorder[(i+1)..^0], inorder[(i+1)..^0]);
        return rootNode;
    }
}
