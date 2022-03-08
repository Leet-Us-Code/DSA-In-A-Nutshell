/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public bool HasCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head; 
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next; 
            if(slow == fast)
                return true;
        }
        return false;
    }
}
