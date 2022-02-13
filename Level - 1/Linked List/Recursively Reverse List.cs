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
    public static ListNode reverseHelper(ListNode head, ref ListNode res)
    {
        if(head == null || head.next == null)
        {
            res = head;
            return head;
        }
        res = head; 
        ListNode rem = reverseHelper(head.next, ref res);
        rem.next = head;
        head.next = null;
        return head;
    }
    public ListNode ReverseList(ListNode head) {
        ListNode res = new ListNode();
        ListNode temp = reverseHelper(head, ref res);
        return res;
    }
}
