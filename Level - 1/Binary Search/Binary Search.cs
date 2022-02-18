public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public int Search(int[] nums, int target) {
        int n = nums.Length; 
        int l = 0, r = n - 1; 
        while(r >= l)
        {
            int mid = (r + l)/2; 
            if(nums[mid] == target)
                return mid; 
            else if(nums[mid] > target)
                r = mid - 1;
            else
                l = mid + 1;
        }
        return -1;
    }
}
