class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public int FirstOccurrence(List<int> nums, int tar)
    {
        int n = nums.Count; 
        int l = 0, r = n - 1; 
        int res = -1;
        while(r >= l)
        {
            int mid = (r + l)/2; 
            if(nums[mid] == tar)
            {
                res = mid; 
                r = mid - 1; 
            }
            else if(nums[mid] > tar)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }
        return res;
    }
    public int LastOccurrence(List<int> nums, int tar)
    {
        int n = nums.Count; 
        int l = 0, r = n - 1; 
        int res = -1;
        while(r >= l)
        {
            int mid = (r + l)/2; 
            if(nums[mid] == tar)
            {
                res = mid; 
                l = mid + 1; 
            }
            else if(nums[mid] > tar)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }
        return res;
    }
    public int findCount(List<int> A, int B) {
        int f = FirstOccurrence(A, B);
        int l = LastOccurrence(A, B);
        if(f == -1 || l == -1)
        return 0; 
        else 
        return l - f + 1;
    }
}
