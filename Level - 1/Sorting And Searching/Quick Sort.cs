public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public void swap(ref int a, ref int b)
    {
        int temp = a; 
        a = b; 
        b = temp;
    }
    public int partition(int[] nums, int l, int r)
    {
        int pivot = nums[r];
        int i = l - 1; 
        for(int j = l; j < r; j++)
        {
            if(nums[j] < pivot)
            {
                i++;
                swap(ref nums[i], ref nums[j]);
            }
        }
        swap(ref nums[i+1], ref nums[r]);
        return i+1;
    }
    public void quickSort(int[] nums, int l, int r)
    {
        if(r > l)
        {
            int p = partition(nums, l, r);
            quickSort(nums, l, p-1);
            quickSort(nums, p+1, r);
        }
        else
            return;
    }
    public int[] SortArray(int[] nums) {
        int n = nums.Length; 
        quickSort(nums, 0, n-1);
        return nums;
    }
}
