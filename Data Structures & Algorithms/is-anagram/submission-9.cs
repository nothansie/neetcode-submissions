public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        var sFrequency = FrequencyMap(s);
        var tFrequency = FrequencyMap(t);

        foreach(var freq in sFrequency){
            if(!tFrequency.ContainsKey(freq.Key)){
                return false;
            }
            if(freq.Value != tFrequency[freq.Key]){
                return false;
            }
        }

        return true;
    }

    public Dictionary<char, int> FrequencyMap(string targetString){
        Dictionary<char, int> frequence = new();
        foreach(var character in targetString){
            if(frequence.ContainsKey(character)){
                frequence[character]++;
            } else {
                frequence[character] = 1;
            }
        }

        return frequence;
    }
}
