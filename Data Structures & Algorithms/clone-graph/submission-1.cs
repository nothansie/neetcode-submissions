/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    Dictionary<int, Node> visited = new Dictionary<int, Node>();
    
    public Node CloneGraph(Node node) {
        if(node == null){
            return null;
        }
        var newNode = new Node(node.val);
        visited[node.val] = newNode;
        for(var i = 0; i < node.neighbors.Count; i++){
            var currentNeighbor = node.neighbors[i];
            if(visited.TryGetValue(currentNeighbor.val, out var existingNeighbor)){
                newNode.neighbors.Add(existingNeighbor);
            } else {
                newNode.neighbors.Add(CloneGraph(node.neighbors[i]));
            }
        }
        return newNode;
    }
}
