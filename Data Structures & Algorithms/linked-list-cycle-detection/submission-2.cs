/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null){
            return false;
        }
        var visited = new HashSet<ListNode>();
        
        var curr = head;
        while(curr.next != null){
            if(visited.Contains(curr.next)){
                return true;
            }
            visited.Add(curr);
            curr = curr.next;
        }
        return false;
    }
}
