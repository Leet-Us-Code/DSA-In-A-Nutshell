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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if(head == null || head.next == null || LengthOfList(head) < k)
            return head;
        int cnt = 0; 
        ListNode ptr = null;
        ListNode temp = head; 
        while(cnt < k && temp != null)
        {
            ListNode nxt = temp.next; 
            temp.next = ptr;
            ptr = temp; 
            temp = nxt;
            cnt++;
        }
        head.next = ReverseKGroup(temp, k);
        return ptr;
    }
}
