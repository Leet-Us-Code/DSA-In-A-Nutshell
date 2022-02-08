public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public bool IsSubsequence(string s, string t) {
        int n = s.Length; 
        int m = t.Length; 
        int p1 = 0, p2 = 0; 
        while(p1 < n && p2 < m)
        {
            if(s[p1] == t[p2])
            {
                p1++;
                p2++;
            }
            else
                p2++;
        }
        if(p1 == n)
            return true;
        return false;
    }
}
