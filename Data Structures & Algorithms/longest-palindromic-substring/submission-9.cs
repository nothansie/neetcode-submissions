public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length == 1){
            return s;
        }
        string longestPalindrome = "";
        for(int i = 0; i < s.Length; i++){
            Expand(i, i);
            Expand(i, i+1);
        }
        return longestPalindrome;

        void Expand(int left, int right){
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
    }
}
