using System;
using System.Collections.Generic;
public class Test
{
	public static void Main()
	{
		// your code goes here
		//OM GAN GANAPATHAYE NAMO NAMAH 
		//JAI SHRI RAM 
		//JAI BAJRANGBALI 
		//AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
		string bigString, smallString; 
		bigString = Console.ReadLine(); 
		smallString = Console.ReadLine(); 
		List<int> inds = new List<int>();
		int n = bigString.Length;
		int ind = bigString.IndexOf(smallString);
		while(ind != -1)
		{
		    inds.Add(ind); 
		    ind = bigString.IndexOf(smallString, ind+1);
		}
		for(int i = 0; i < inds.Count; i++)
		{
		    Console.WriteLine(inds[i] + " ");
		}
	}
}
