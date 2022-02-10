using System;
//OM GAN GANAPATHAYE NAMO NAMAH 
//JAI SHRI RAM 
//JAI BAJRANGBALI 
//AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
public class Test
{
    public static void merge(int[] arr, int l, int mid, int r)
    {
        int n1 = mid - l +1; 
        int n2 = r - mid; 
        int[] left = new int[n1];
        int[] right = new int[n2];
        for(int i1 = 0; i1 < n1; i1++)
        {
            left[i1] = arr[l + i1];
        }
        for(int i1 = 0; i1 < n2; i1++)
        {
            right[i1] = arr[mid + 1 + i1];
        }
        int i = 0, j = 0, k = l;
        while(i < n1 && j < n2)
        {
            if(left[i] > right[j])
            {
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
    }
    public static void mergeSort(int[] arr, int l, int r)
    {
        if(r > l)
        {
            int mid = (r + l)/2; 
            mergeSort(arr, l, mid);
            mergeSort(arr, mid+1, r);
            merge(arr, l, mid, r);
        }
    }
	public static void Main()
	{
		string length = Console.ReadLine(); 
		int n = Convert.ToInt32(length); 
		int[] arr = new int[n];
		for(int i = 0; i < n; i++)
		{
		    string ele = Console.ReadLine(); 
		    arr[i] = Convert.ToInt32(ele);
		}
		mergeSort(arr, 0, n-1);
		for(int i = 0; i < n; i++)
		{
		    Console.WriteLine(arr[i]);
		}
	}
}
