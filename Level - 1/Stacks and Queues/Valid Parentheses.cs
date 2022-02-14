public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public bool IsValid(string s) {
        int n = s.Length; 
        Stack<char> st = new Stack<char>();
        for(int i = 0; i < n; i++)
        {
            if(st.Count == 0 || s[i] == '(' || s[i] == '{' || s[i] == '[')
                st.Push(s[i]);
            else 
            {
                if(s[i] == ')')
                {
                    if(st.Peek() == '(')
                        st.Pop();
                    else
                        return false;
                }
                else if(s[i] == '}')
                {
                    if(st.Peek() == '{')
                        st.Pop();
                    else
                        return false;
                }
                else if(s[i] == ']')
                {
                    if(st.Peek() == '[')
                        st.Pop();
                    else
                        return false;
                }
            }
        }
        if(st.Count == 0)
            return true;
        return false;
    }
}
