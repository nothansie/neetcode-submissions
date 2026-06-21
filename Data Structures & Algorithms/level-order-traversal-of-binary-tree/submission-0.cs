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
        Queue<(TreeNode, int)> treeQueue = new Queue<(TreeNode, int)>();
        List<List<int>> resultList = new List<List<int>>();

        treeQueue.Enqueue((root, 0));

        while(treeQueue.Count > 0){
            var currentTracker = treeQueue.Dequeue();
            var currentNode = currentTracker.Item1;
            var currentDepth = currentTracker.Item2;

            if(resultList.Count - 1 < currentDepth){
                resultList.Add(new List<int>());
            }
            resultList[currentDepth].Add(currentNode.val);

            if(currentNode.left != null){
                treeQueue.Enqueue((currentNode.left, currentDepth + 1));
            }
            if(currentNode.right != null){
                treeQueue.Enqueue((currentNode.right, currentDepth + 1));
            }
        }

        return resultList;
    }
}
