using System;
//OM GAN GANAPATHAYE NAMO NAMAH 
//JAI SHRI RAM 
//JAI BAJRANGBALI 
//AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
public class Node 
{
    public int data; 
    public Node next;
    public Node(int data)
    {
        this.data = data; 
        this.next = null;
    }
}
public class Test
{
    public static Node InsertAtFront(Node head, int data)
    {
        if(head == null)
        {
            head = new Node(data);
            return head;
        }
        Node ptr = new Node(data);
        ptr.next = head; 
        head = ptr;
        return head;
    }
    public static Node InsertAtEnd(Node head, int data)
    {
        Node ptr = new Node(data); 
        if(head == null)
        {
            head = ptr;
            return head;
        }
        Node temp = head; 
        while(temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = ptr;
        ptr.next = null;
        return head;
    }
    public static Node InsertAtMiddle(Node head, int pos, int data)
    {
        Node newNode = new Node(data);
        if(head == null)
        {
            head = newNode;
            return head;
        }
        Node temp = head; 
        for(int i = 0; i < pos - 1; i++)
        {
            temp = temp.next;
        }
        Node nextNode = temp.next; 
        temp.next = newNode; 
        newNode.next = nextNode;
        return head;
    }
    public static void DisplayList(Node head)
    {
        while(head != null)
        {
            Console.Write(head.data + " ");
            head = head.next;
        }
    }
	public static void Main()
	{
		// your code goes here
		Node head = new Node(3); 
		head = InsertAtFront(head, 2);
		head = InsertAtFront(head, 1);
		head = InsertAtEnd(head, 4);
		head = InsertAtMiddle(head, 2, 5);
		DisplayList(head);
	}
}
