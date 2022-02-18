public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public int FindPivot(int[] nums)
    {
        int n = nums.Length; 
        int res = 0; 
        int l = 0, r = n-1; 
        while(r >= l)
        {
            int mid = (r + l)/2; 
            if(nums[mid] <= nums[n-1])
            {
                res = mid;
                r = mid - 1; 
            }
            else
                l = mid + 1;
        }
        return res;
    }
    public int Search(int[] nums, int l, int r, int tar)
    {
        while(r >= l)
        {
            int mid = (r + l)/2; 
            if(nums[mid] == tar)
            {
                return mid;
            }
            else if(nums[mid] > tar)
                r = mid - 1;
            else
                l = mid + 1;
        }
        return -1;
    }
    public int Search(int[] nums, int target) {
        int pivot = FindPivot(nums); 
        int n = nums.Length;
        int s1 = Search(nums, 0, pivot-1, target);
        int s2 = Search(nums, pivot, n-1, target);
        return Math.Max(s1, s2);
    }
}
