public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        var wordLookup = new HashSet<string>();
        var dp = new Dictionary<int, bool>();
        
        for(int k = 0; k < wordDict.Count; k++){
            wordLookup.Add(wordDict[k]);
        }
        return CanBreak(0);

        bool CanBreak(int startIndex){
            if(dp.TryGetValue(startIndex, out var value)){
                return value;
            }
            if(startIndex == s.Length) {
                dp[startIndex] = true;
                return true;
            }

            for(int endIndex = startIndex + 1; endIndex <= s.Length; endIndex++){
                var prefix = s[startIndex..(endIndex)];

                if(wordLookup.Contains(prefix) && CanBreak(endIndex)){
                    dp[startIndex] = true;
                    return true;
                }
            }
            dp[startIndex] = false;
            return false;
        }
    }
}
