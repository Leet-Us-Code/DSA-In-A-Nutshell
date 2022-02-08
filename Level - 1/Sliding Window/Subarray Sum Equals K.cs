
public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public int SubarraySum(int[] nums, int k) {
        int n = nums.Length;
        int[] prefix = new int[n+1];
        prefix[0] = 0; 
        for(int i = 1; i <= n; i++)
        {
            prefix[i] = nums[i-1] + prefix[i-1];
        }
        int count = 0;
        Dictionary<int, int> mp = new Dictionary<int, int>();
        for(int i = 0; i <= n; i++)
        {
            int tar = prefix[i] - k; 
            if(mp.ContainsKey(tar) == true)
            {
                count += mp[tar];
            }
            if(mp.ContainsKey(prefix[i]))
            {
                mp[prefix[i]]++;
            }
            else
            {
                mp[prefix[i]] = 1;
            }
        }
        return count;
    }
}
