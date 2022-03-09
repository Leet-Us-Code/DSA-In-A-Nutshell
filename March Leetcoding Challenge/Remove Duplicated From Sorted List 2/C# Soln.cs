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
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode cur = head; 
        ListNode prev = new ListNode(0);
        prev.next = head;
        ListNode res = prev;
        while(cur != null)
        {
            if(cur != null && cur.next != null && cur.val == cur.next.val)
            {
                while(cur.next != null && cur != null && cur.next.val == cur.val)
                    cur = cur.next;
                cur = cur.next; 
                prev.next = cur;
            }
            else 
            {
                prev = cur;
                cur = cur.next;
            }
        }
        return res.next;
    }
}
