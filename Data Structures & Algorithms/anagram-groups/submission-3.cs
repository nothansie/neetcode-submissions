public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var frequencyMap = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; i++){
            var count = new int[26];

            for(int k = 0; k < strs[i].Length; k++){
                count[strs[i][k] - 'a']++;
            }

            var key = string.Join('-', count);

            if(frequencyMap.TryGetValue(key, out var value)){
                frequencyMap[key].Add(strs[i]);
            } else {
                frequencyMap[key] = new List<string>();
                frequencyMap[key].Add(strs[i]);
            }
        }

        var result = new List<List<string>>();
        foreach(var group in frequencyMap){
            result.Add(group.Value);
        }

        return result;
    }
}
