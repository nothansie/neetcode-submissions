public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequencyMap = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            var currentNum = nums[i];
            if(frequencyMap.ContainsKey(currentNum)){
                frequencyMap[currentNum]++;
            } else {
                frequencyMap[currentNum] = 1;
            }
        }

        var buckets = new List<int>[nums.Length];
        
        for(int i = 0; i < buckets.Length; i++){
            buckets[i] = new List<int>();
        }

        foreach(var numFrequency in frequencyMap){
            buckets[numFrequency.Value - 1].Add(numFrequency.Key);
        }
        
        var result = new int[k];
        int topFound = 0;
        for(int i = buckets.Length - 1; i >= 0; i--){
            if(buckets[i].Count > 0){
                for(int x = 0; x < buckets[i].Count; x++){
                    if(topFound < k){
                        result[topFound] = buckets[i][x];
                        topFound++;
                    } else {
                        return result;
                    }
                }
            }
        }
        return result;
    }
}
