public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var frequencyMaps = new List<Dictionary<char, int>>();
        var output = new List<List<string>>();

        for(int i = 0; i < strs.Length; i++){
            var strFrequencyMap = new Dictionary<char, int>();
        
            for(int k = 0; k < strs[i].Length; k++){
                char currentChar = strs[i][k];
                if(strFrequencyMap.TryGetValue(currentChar, out var freq)){
                    strFrequencyMap[currentChar] = freq + 1;
                } else {
                    strFrequencyMap[currentChar] = 1;
                }
            }

            bool anyMatch = false;
            for(int k = 0; k < frequencyMaps.Count; k++){
                bool isInvalid = false;
                if(frequencyMaps[k].Count != strFrequencyMap.Count){
                    continue;
                }
                foreach(var key in frequencyMaps[k].Keys){
                    if(strFrequencyMap.TryGetValue(key, out var freq) && freq == frequencyMaps[k][key]){
                        continue;
                    } else {
                        isInvalid = true;
                        break;
                    }
                }
                if(!isInvalid && k < output.Count){
                    output[k].Add(strs[i]);
                    anyMatch = true;
                    break;
                }
            }
            if(!anyMatch){
                frequencyMaps.Add(strFrequencyMap);
                output.Add(new List<string> { strs[i] });
            }
        }

        return output;
    }
}
