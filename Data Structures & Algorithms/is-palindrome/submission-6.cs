public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        int left = 0;
        int right = s.Length - 1;
        while(left < right){
            while(!char.IsLetterOrDigit(s[left]) && left < s.Length - 1){
                left++;
            }
            while(!char.IsLetterOrDigit(s[right]) && right > 0){
                right--;
            }
            if(right <= left){
                return true;
            }
            if(s[left] != s[right]){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
