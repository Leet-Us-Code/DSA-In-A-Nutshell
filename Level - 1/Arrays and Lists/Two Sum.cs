public class Pair : IComparable<Pair>
{
    public int val; 
    public int ind; 
    public Pair(int val1, int ind1)
    {
        val = val1; 
        ind = ind1;
    }
    public int CompareTo(Pair obj)
    {
        return val.CompareTo(obj.val);
    }
}
public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public int[] TwoSum(int[] nums, int target) {
        List<Pair> pairs = new List<Pair>();
        int n = nums.Length; 
        for(int i = 0; i < n; i++)
        {
            Pair p = new Pair(nums[i], i);
            pairs.Add(p);
        }
        pairs.Sort();
        int len = pairs.Count(); 
        int l = 0, r = len-1; 
        int[] res = new int[2];
        while(r > l)
        {
            if(pairs[r].val + pairs[l].val == target)
            {
                res[0] = pairs[l].ind; 
                res[1] = pairs[r].ind;
                break;
            }
            else if(pairs[r].val + pairs[l].val > target)
                r--;
            else 
                l++;
        }
        return res;
    }
}
