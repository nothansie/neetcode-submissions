public class Solution {
    public int CountSubstrings(string s) {
        var palindromes = 0;
        for(int i = 0; i < s.Length; i++){
            palindromes += PalindromesFromCenter(i,i);
            palindromes += PalindromesFromCenter(i,i+1);
        }
        return palindromes;

        int PalindromesFromCenter(int left, int right){
            var palindromesFromCenter = 0;
            while(left >= 0 && right < s.Length && s[left] == s[right]){
                palindromesFromCenter++;
                left--;
                right++;
            }
            return palindromesFromCenter;
        }
    }
}
