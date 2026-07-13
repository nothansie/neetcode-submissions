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
    public List<int> RightSideView(TreeNode root) {
        if(root == null){
            return [];
        }
        var queue = new Queue<(TreeNode node, int depth)>();
        var resultList = new List<int>();

        queue.Enqueue((root, 0));
        
        while(queue.Count > 0){
            var current = queue.Dequeue();
            if(queue.Count > 0){
                var next = queue.Peek();
                if(next.depth > current.depth){
                    resultList.Add(current.node.val);
                }
            } else {
                resultList.Add(current.node.val);
            }
            if(current.node.left != null){
                queue.Enqueue((current.node.left, current.depth + 1));
            }
            if(current.node.right != null){
                queue.Enqueue((current.node.right, current.depth + 1));
            }
        }

        return resultList;
    }
}
