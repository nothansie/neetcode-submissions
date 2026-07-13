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
    public int GoodNodes(TreeNode root) {
        var queue = new Queue<(TreeNode node, int minValue)>();
        int goodNodes = 0;

        queue.Enqueue((root, root.val));
        
        while(queue.Count > 0){
            var current = queue.Dequeue();
            if(current.node.val >= current.minValue){
                goodNodes++;
            }
            if(current.node.left != null){
                queue.Enqueue((current.node.left, Math.Max(current.minValue, current.node.val)));
            }
            if(current.node.right != null){
                queue.Enqueue((current.node.right, Math.Max(current.minValue, current.node.val)));
            }
        }

        return goodNodes;
    }
}
