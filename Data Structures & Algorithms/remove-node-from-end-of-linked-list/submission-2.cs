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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode? dummy = new ListNode(0, head);
        ListNode? first = dummy;
        ListNode? second = dummy;

        for(int i = 0; i <= n; i++){
            second = second.next;
        }

        while(second != null){
            first = first.next;
            second = second.next;
        }

        first.next = first.next.next;
    
        return dummy.next;
    }
}
