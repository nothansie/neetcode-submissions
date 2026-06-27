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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null && subRoot == null){
            return true;
        } else if(root == null || subRoot == null){
            return false;
        } else if(root.val == subRoot.val) {
            if(IsSameTree(root, subRoot)){
                return true;
            } else {
                return (IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot));
            }
        } else {
            return (IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot));
        }
    }

    public bool IsSameTree(TreeNode root, TreeNode subRoot){
        if(root == null && subRoot == null){
            return true;
        } else if(root == null || subRoot == null){
            return false;
        } else if(root.val == subRoot.val){
            return (IsSameTree(root.left, subRoot.left) && IsSameTree(root.right, subRoot.right));
        } else {
            return false;
        }
    }
}
