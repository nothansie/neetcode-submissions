public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length == 1){
            return s;
        }
        
        int bestLength = 0;
        int bestLeft = 0;

        for(int i = 0; i < s.Length; i++){
            Expand(i, i);
            Expand(i, i+1);
        }
        return s[bestLeft..(bestLeft + bestLength + 1)];

        void Expand(int left, int right){
            while(left >= 0 && right < s.Length){
                if(s[left] != s[right]){
                    break;
                }
                if(right - left > bestLength){
                    bestLength = right - left;
                    bestLeft = left;
                }
                left--;
                right++;
            }
        }
    }
}
