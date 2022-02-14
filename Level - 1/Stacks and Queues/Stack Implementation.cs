using System;
//OM GAN GANAPATHAYE NAMO NAAMH 
//JAI SHRI RAM 
//JAI BAJRANGBALI 
//AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
public class Stack
{
    public int top = -1; 
    public int[] arr = new int[1000];
    public static int maxEle = 1000; 
    public bool IsEmpty()
    {
        if(top == -1)
        return true;
        return false;
    }
    public void Push(int x)
    {
        if(top == maxEle)
        {
            Console.WriteLine("Stack is full!!");
            return;
        }
        top++;
        arr[top] = x;
    }
    public int Pop()
    {
        if(top == -1)
        return -1; 
        int x = arr[top];
        top--;
        return x;
    }
    public int Top()
    {
        if(top == -1)
        return -1;
        return arr[top];
    }
}
public class Test
{
	public static void Main()
	{
		// your code goes here
		Stack st = new Stack();
		st.Push(1);
		st.Push(2);
		st.Push(3);
		//displaying all elements in stack at the same time popping them 
		while(!st.IsEmpty())
		{
		    int x = st.Top();
		    Console.WriteLine(x);
		    st.Pop();
		}
	}
}
