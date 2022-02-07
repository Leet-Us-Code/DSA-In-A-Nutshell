public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public bool isPeak(int[] arr, int i)
    {
        int n = arr.Length; 
        if(i == 0 || i == n-1)
            return false;
        else 
        {
            if(arr[i] > arr[i+1] && arr[i] > arr[i-1])
                return true;
            else
                return false;
        }
    }
    public int LongestMountain(int[] arr) {
        List<int> peaks = new List<int>();
        int n = arr.Length;
        for(int i = 0; i < n; i++)
        {
            if(isPeak(arr, i))
            {
                peaks.Add(i);
            }
        }
        int len = peaks.Count(); 
        int maxRange = 0;
        for(int i = 0; i < len; i++)
        {
            int l = peaks[i]; 
            int r = peaks[i];
            while(l > 0 && arr[l] > arr[l-1])
                l--;
            while(r < n-1 && arr[r] > arr[r+1])
                r++;
            maxRange = Math.Max(maxRange, r-l+1);
        }
        return maxRange;
    }
}
