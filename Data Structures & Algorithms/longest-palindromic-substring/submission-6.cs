public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length == 1){
            return s;
        }
        string longestPalindrome = "";
        for(int i = 0; i < s.Length; i++){
            int left = i;
            int right = i;
            while(left >= 0 && right < s.Length){
                if(s[left] != s[right]){
                    break;
                }
                if(s[left..(right+1)].Length > longestPalindrome.Length){
                    longestPalindrome = s[left..(right+1)];
                }
                left--;
                right++;
            }
        }
        for(int i = 0; i < s.Length; i++){
            int left = i;
            int right = i+1;
            while(left >= 0 && right < s.Length){
                if(s[left] != s[right]){
                    break;
                }
                if(s[left..(right+1)].Length > longestPalindrome.Length){
                    longestPalindrome = s[left..(right+1)];
                }
                left--;
                right++;
            }
        }
        return longestPalindrome;
    }
}
