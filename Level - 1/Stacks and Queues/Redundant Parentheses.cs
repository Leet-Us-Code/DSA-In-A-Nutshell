using System;
using System.Collections.Generic;
public class Test
{
    public static bool findRedundantHelper(string s)
    {
        Stack<char> st = new Stack<char>(); 
        int n = s.Length; 
        for(int i = 0; i < n; i++)
        {
            if(st.Count == 0 || s[i] != ')')
            {
                st.Push(s[i]);
            }
            else 
            {
                if(s[i] == ')')
                {
                    if(st.Peek() == '(')
                    return true;
                    else 
                    {
                        while(st.Count!= 0 && st.Peek() != '(')
                        {
                            st.Pop();
                        }
                        st.Pop();
                    }
                }
            }
        }
        return false;
    }
    public static void findRedundant(string s)
    {
        if(findRedundantHelper(s))
        {
            Console.WriteLine("There is redundancy");
        }
        else 
        {
            Console.WriteLine("There is no redundancy");
        }
    }
	public static void Main()
	{
		// your code goes here
		string str = "((a+b))";
        findRedundant(str);
 
        str = "(a+(b)/c)";
        findRedundant(str);
 
        str = "(a+b*(c-d))";
        findRedundant(str);
	}
}
