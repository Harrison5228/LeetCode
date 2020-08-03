/*
Runtime: 376 ms  Your runtime beats 88.85 % of csharp submissions.
Memory Usage: 34.8 MB  Your memory usage beats 37.50 % of csharp submissions.
*/
//Accepted
public class Solution {
    public void ReverseString(char[] s) {
        int half = s.Length / 2;
        for(int count = 0,l_index = 0, r_index = s.Length - 1; count < half; count++, l_index++, r_index--){
            
            if((s[l_index] == s[r_index]) || (l_index == r_index))
                continue;
            
            else
            {
                var temp = s[l_index];
                s[l_index] =  s[r_index];
                s[r_index] = temp;
            }
            
        }
    }
}
