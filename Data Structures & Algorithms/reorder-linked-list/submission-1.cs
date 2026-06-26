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
    public void ReorderList(ListNode head) {
        ListNode? slow = head;
        ListNode? fast = head.next;

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode? reverseHead = slow.next;
        ListNode? prev = null;
        
        slow.next = null;

        while(reverseHead != null){
            ListNode? next = reverseHead.next;
            reverseHead.next = prev;
            
            prev = reverseHead; 
            reverseHead = next;
        }

        ListNode? mergeHead = head;
        reverseHead = prev;
        while(mergeHead != null && reverseHead != null){
            ListNode? mergeNext = mergeHead.next;
            mergeHead.next = reverseHead;
            ListNode? reverseNext = reverseHead.next;
            reverseHead.next = mergeNext;
            
            reverseHead = reverseNext;
            mergeHead = mergeNext;
        }
    }
}
