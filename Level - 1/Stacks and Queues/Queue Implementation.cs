using System;
//OM GAN GANAPATHAYE NAMO NAMAH 
//JAI SHRI RAM 
//JAI BAJRANGBALI 
//AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
public class Queue
{
    public int rear = -1, front = 0;
    public static int maxEle = 1000;
    public int[] arr = new int[maxEle];
    public bool IsEmpty()
    {
        if(front == rear + 1)
            return true;
        return false;
    }
    public void Enqueue(int x)
    {
        if(rear == maxEle)
        {
            Console.WriteLine("Queue is full");
            return;
        }
        else 
        {
            rear++;
            arr[rear] = x;
            return;
        }
    }
    public int Dequeue()
    {
        if(front == rear + 1)
        return -1;
        int x = arr[front];
        front++;
        return x;
    }
    public int Top()
    {
        if(front == rear + 1)
        return -1; 
        return arr[front];
    }
}
public class Test
{
	public static void Main()
	{
		// your code goes here
		Queue q = new Queue(); 
		q.Enqueue(1);
		q.Enqueue(2);
		q.Enqueue(3);
		q.Enqueue(4);
		while(!q.IsEmpty())
		{
		    Console.WriteLine(q.Top());
		    q.Dequeue();
		}
	}
}
