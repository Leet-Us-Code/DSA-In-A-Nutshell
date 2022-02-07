public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public IList<IList<int>> ThreeSum(int[] nums) {
        var res = new List<IList<int>>();
        int n = nums.Length; 
        Array.Sort(nums); 
        for(int i = 0; i < n-1; i++)
        {
            int tar = 0 - nums[i]; 
            int l = i + 1; 
            int r = n - 1;
            while(r > l)
            {
                if(nums[r] + nums[l] == tar)
                {
                    //remove duplicates
                    while(l < n-1 && nums[l] == nums[l+1])
                        l++;
                    while(r > 0 && nums[r] == nums[r-1])
                        r--; 
                    IList<int> temp = new List<int>(); 
                    temp.Add(nums[i]);
                    temp.Add(nums[l]);
                    temp.Add(nums[r]);
                    res.Add(temp);
                    l++;
                    r--;
                }
                else if(nums[r] + nums[l] > tar)
                    r--;
                else
                    l++;
            }
            //remove duplicates 
            while(i < n-1 && nums[i] == nums[i+1])
                i++;
        }
        return res;
    }
}
