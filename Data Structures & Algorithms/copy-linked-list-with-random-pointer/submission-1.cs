/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
                var nodeMap = new Dictionary<Node, Node>();
        Node newHead = new Node(0);
        var prev = newHead;
        var current = head;

        while(current != null){
            var newNode = FindOrCreate(current);
            
            if(current.random != null){
                var randomNode = FindOrCreate(current.random);
                newNode.random = randomNode;
            }
            prev.next = newNode;
            prev = prev.next;
            current = current.next;
        }

        return newHead.next;

        Node FindOrCreate(Node targetNode){
            if(nodeMap.ContainsKey(targetNode)){
                return nodeMap[targetNode];
            } else {
                var newNode = new Node(targetNode.val);
                nodeMap[targetNode] = newNode;
                return newNode;
            }
        } 
    }
}
