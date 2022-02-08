public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length; 
        int p1 = 0, p2 = 0, len = 0; 
        int[] freq = new int[128]; 
        for(int i = 0; i < 128; i++)
            freq[i] = 0; 
        while(p1 < n && p2 < n)
        {
            char ch = s[p2];
            freq[ch]++; 
            while(p1 < p2 && freq[ch] > 1)
            {
                freq[s[p1]]--;
                p1++;
            }
            len = Math.Max(len, p2-p1+1);
            p2++;
        }
        return len;
    }
}
