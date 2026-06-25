public class Solution {
    public int CharacterReplacement(string s, int k) {
        var frequencyMap = new Dictionary<char, int>();
        var left = 0;
        var longest = 0;

        for(int right = 0; right < s.Length; right++){
            if(frequencyMap.ContainsKey(s[right])){
                frequencyMap[s[right]]++;
            } else {
                frequencyMap[s[right]] = 1;
            }

            var mostCommon = frequencyMap.Values.Max();
            if(right + 1 - left - mostCommon <= k){
                longest = Math.Max(longest, right + 1 - left);
            } else {
                while(right + 1 - left - mostCommon > k){
                    frequencyMap[s[left]]--;
                    left++;
                    mostCommon = frequencyMap.Values.Max();
                }
            }
        }

        return longest;
    }
}
