public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length == 1){
            return s;
        }
        var palindromeCache = new Dictionary<string, bool>();
        string longestPalindrome = "";
        for(int i = 0; i < s.Length; i++){
            int left = i;
            int right = i;
            while(left != 0 || right != s.Length - 1){
                if(left > 0){
                    left--;
                }
                var isAttemptOnePalindrome = false;
                isAttemptOnePalindrome = isPalindrome(s[left..(right+1)]);
                if(right < s.Length - 1){
                    right++;
                }
                var isAttemptTwoPalindrome = isPalindrome(s[left..(right+1)]);
                if(!isAttemptOnePalindrome && !isAttemptTwoPalindrome){
                    break;
                }
            }
        }
        return longestPalindrome;

        bool isPalindrome(string checkString){
            if(palindromeCache.ContainsKey(checkString)){
                return palindromeCache[checkString];
            }

            bool isPalindrome = true;
            int left = 0;
            int right = checkString.Length - 1;
            while(left < right){
                if(checkString[left] != checkString[right]){
                    isPalindrome = false;
                    break;
                }
                left++;
                right--;
            }
            palindromeCache[checkString] = isPalindrome;
            if(isPalindrome && checkString.Length > longestPalindrome.Length){
                longestPalindrome = checkString; 
            }
            return isPalindrome;
        }
    }
}
