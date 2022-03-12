/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public int LengthOfList(ListNode head)
    {
        int len = 0; 
        while(head != null)
        {
            len++;
            head = head.next;
        }
        return len;
    }
    public ListNode NodeAtInd(ListNode head, int ind)
    {
        int len = LengthOfList(head); 
        if(head == null)
            return head;
        if(ind > len)
            return null;
        else
        {
            int cntr = 0; 
            ListNode ptr = head;
            while(ptr != null && cntr < ind-1)
            {
                cntr++;
                ptr = ptr.next;
            }
            return ptr;
        }
    }
    public ListNode rotateRight(ListNode head, int k) {
        if(head == null)
            return null;
        int n = LengthOfList(head);
        k = k%n;
        if(k ==0)
            return head;
        ListNode ptr = NodeAtInd(head, n-k);
        ListNode ptrL = NodeAtInd(ptr.next, k);
        ListNode res = ptr.next;
        ptr.next = null;
        ptrL.next = head;
        return res;
    }
}
