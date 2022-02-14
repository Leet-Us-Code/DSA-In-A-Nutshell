public class Solution {
    //OM GAN GANAPATHAYE NAMO NAMAH 
    //JAI SHRI RAM 
    //JAI BAJRANGBALI 
    //AMME NARAYANA, DEVI NARAYANA, LAKSHMI NARAYANA, BHADRE NARAYANA
    //do this question with the help of queues
    public int FirstUniqChar(string s) {
        Queue<int> mq = new Queue<int>();
        int n = s.Length; 
        List<int> res = new List<int>();
        Dictionary<char, int> freq = new Dictionary<char, int>();
        for(int i = 0; i < n; i++)
        {
            //increment the frequency
            if(freq.ContainsKey(s[i]))
                freq[s[i]]++;
            else
                freq[s[i]] = 1;
            mq.Enqueue(i); // push the index as thats what we need in the answer
            while(mq.Count != 0 && freq[s[mq.Peek()]] > 1)
            {
                mq.Dequeue();
            }
            if(mq.Count != 0)
                res.Add(mq.Peek());
            else
                res.Add(-1);
        }
        int x = res.Count; 
        return res[x-1];
    }
}
