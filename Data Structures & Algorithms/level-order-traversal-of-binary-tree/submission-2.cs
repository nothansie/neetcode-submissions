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
    public List<List<int>> LevelOrder(TreeNode root) {
        if(root == null){
            return new List<List<int>>();
        }
        var nodeQueue = new Queue<(int depth, TreeNode node)>();
        nodeQueue.Enqueue((0, root));
        
        var result = new List<List<int>>();
        while(nodeQueue.Count > 0){
            var currentNode = nodeQueue.Dequeue();
            if(currentNode.depth >= result.Count){
                result.Add(new List<int>());
            }
            result[currentNode.depth].Add(currentNode.node.val);
            if(currentNode.node.left != null){
                nodeQueue.Enqueue((currentNode.depth + 1, currentNode.node.left));
            }
            if(currentNode.node.right != null){
                nodeQueue.Enqueue((currentNode.depth + 1, currentNode.node.right));
            }
        }
        return result;
    }
}
