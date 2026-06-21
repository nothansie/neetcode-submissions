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
    private Dictionary<Node, Node> visited = new Dictionary<Node, Node>();

    public Node CloneGraph(Node node) {
        if(node == null){
            return node;
        }
        var newNode = new Node();
        newNode.val = node.val;

        if(visited.ContainsKey(node)){
            return visited[node];
        }

        visited.Add(node, newNode);

        List<Node> newNeighbours = new List<Node>();
        for(int i = 0; i < node.neighbors.Count; i++){
            newNeighbours.Add(CloneGraph(node.neighbors[i]));
        }
        newNode.neighbors = newNeighbours;

        return newNode;
    }
}
