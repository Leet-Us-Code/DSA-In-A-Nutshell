public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public string MinWindow(string s, string t) {
        int n = s.Length, m = t.Length; 
        int[] freq1 = new int[128];
        int[] freq2 = new int[128]; 
        for(int i = 0; i < 128; i++)
        {
            freq1[i] = 0; 
            freq2[i] = 0;
        }
        for(int i = 0; i < m; i++)
        {
            int ch = t[i];
            freq1[ch]++;
        }
        int matched = 0, minLen = Int32.MaxValue, start = -1;
        int p1 = 0, p2 = 0; 
        for(p2 = 0; p2 < n; p2++)
        {
            freq2[s[p2]]++;
            if(freq1[s[p2]] > 0 && freq2[s[p2]] <= freq1[s[p2]])
                matched++;
            if(matched == m)
            {
                //remove useless characters
                while(p1 < p2 && (freq1[s[p1]] == 0 || freq2[s[p1]] > freq1[s[p1]]))
                {
                    freq2[s[p1]]--;
                    p1++;
                }
                //be sure to keep this inside -> update only if it is matched else leave
                if(minLen > p2-p1+1)
                {
                    minLen = p2-p1+1;
                    start = p1;
                }
            }
            
        }
        if(start == -1)
            return "";
        return s.Substring(start, minLen);
    }
}
