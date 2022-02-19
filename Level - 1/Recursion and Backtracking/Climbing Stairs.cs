public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    public int ClimbStairs(int n) {
        if(n == 1 || n == 2)
            return n; 
        else
            return ClimbStairs(n-1) + ClimbStairs(n-2);
    }
}
