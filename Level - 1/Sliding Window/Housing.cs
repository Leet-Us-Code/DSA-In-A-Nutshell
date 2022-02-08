public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public int SubarraySum(int[] nums, int k) {
        int p1 = 0, p2 = 0;
        int sum = 0, count = 0;
        int n = nums.Length;
        while(p1 < n && p2 < n)
        {
            sum += nums[p2];
            while(p1 < p2 && sum > k)
            {
                sum -= nums[p1];
                p1++;
            }
            if(sum == k)
                count++;
            p2++;
        }
        return count;
    }
}
