class Result
{

    /*
     * Complete the 'countInversions' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    //OM GAN GANAPATHAYE NAMO NAMAH
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public static long merge(ref List<int> arr, int l, int mid, int r)
    {
        int n1 = mid - l + 1; 
        int n2 = r - mid; 
        int[] left = new int[n1];
        int[] right = new int[n2];
        for(int ind = 0; ind < n1; ind++)
        {
            left[ind] = arr[ind + l];
        }
        for(int ind = 0; ind < n2; ind++)
        {
            right[ind] = arr[ind + mid + 1];
        }
        int cnt = 0, i = 0, j = 0, k = l; 
        while(i < n1 && j < n2)
        {
            if(left[i] > right[j])
            {
                cnt += (n1 - i);
                arr[k++] = right[j++];
            }
            else
            {
                arr[k++] = left[i++];
            }
        }
        while(i < n1)
        {
            arr[k++] = left[i++];
        }
        while(j < n2)
        {
            arr[k++] = right[j++];
        }
        return cnt;
    }
    public static long countInversionsHelper(ref List<int> arr, int l, int r)
    {
        if(r > l)
        {
            int mid = (r + l)/2; 
            long c1 = countInversionsHelper(ref arr, l, mid);
            long c2 = countInversionsHelper(ref arr, mid+1, r);
            long c3 = merge(ref arr, l, mid, r);
            return c1 + c2 + c3;
        }
        return 0;
    }
    public static long countInversions(List<int> arr)
    {
        int l = 0, r = arr.Count-1;
        long res = countInversionsHelper(ref arr, l, r);
        return res;
    }

}
