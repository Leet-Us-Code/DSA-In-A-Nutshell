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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carry = 0; 
        ListNode temp = new ListNode(0);
        ListNode res = temp; 
        while(l1 != null && l2 != null)
        {
            int x = carry + l1.val + l2.val;
            if(x >= 10)
                carry = x/10; 
            else
                carry = 0;
            temp.next = new ListNode(x%10);
            temp = temp.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        while(l1 != null)
        {
            int x = carry + l1.val;
            if(x >= 10)
                carry = x/10;
            else
                carry = 0;
            temp.next = new ListNode(x%10);
            temp = temp.next;
            l1 = l1.next;
        }
        while(l2 != null)
        {
            int x = carry + l2.val;
            if(x >= 10)
                carry = x/10; 
            else
                carry = 0;
            temp.next = new ListNode(x%10);
            temp = temp.next;
            l2 = l2.next;
        }
        if(carry != 0)
            temp.next = new ListNode(carry);
        return res.next;
    }
}
