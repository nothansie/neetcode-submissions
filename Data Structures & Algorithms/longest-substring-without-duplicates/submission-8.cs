public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longest = 0;

        int i = 0;
        int k = 0;

        HashSet<char> visited = new HashSet<char>();

        while(i < s.Length && k < s.Length){
            if(!visited.Contains(s[k])){
                visited.Add(s[k]);
                longest = Math.Max(longest, (1 + k - i));
                k++;
            } else {
                while(visited.Contains(s[k])){
                    visited.Remove(s[i]);
                    i++;
                }
            }
        }

        return longest;
    }
}
