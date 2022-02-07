//OM GAN GANAPATHAYE NAMO NAMAH 
//JAI SHRI RAM 
//JAI BAJRANGBALI 
//AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
public class MyString : IComparable<MyString>
{
    public string s; 
    public MyString(string s)
    {
        this.s = s;
    }
    public int CompareTo(MyString ms)
    {
        string s1 = s + ms.s; 
        string s2 = ms.s + s; 
        return s1.CompareTo(s2);
    }
}
public class Solution {
    public string LargestNumber(int[] nums) {
        int n = nums.Length; 
        MyString[] msArr = new MyString[n]; 
        for(int i = 0; i < n; i++)
        {
            MyString ms = new MyString(nums[i].ToString());
            msArr[i] = ms;
        }
        Array.Sort(msArr); 
        string res = ""; 
        for(int i = n-1; i >= 0; i--)
        {
            res += msArr[i].s;
        }
        if(res[0] == '0')
            return "0";
        return res;
    }
}
