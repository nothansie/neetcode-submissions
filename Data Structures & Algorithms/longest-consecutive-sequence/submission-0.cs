public class Solution {
    public int LongestConsecutive(int[] nums) {
        var uniqueNumbers = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            uniqueNumbers.Add(nums[i]);
        }

        var startingPoints = new List<int>();
        foreach(var num in uniqueNumbers){
            if(!uniqueNumbers.Contains(num - 1)){
                startingPoints.Add(num);
            }
        }
        
        int longestSequence = 0;
        for(int i = 0; i < startingPoints.Count; i++){
            var count = 0;
            while(uniqueNumbers.Contains(startingPoints[i] + count)){
                count++;
            }
            longestSequence = Math.Max(longestSequence, count);
        }

        return longestSequence;
    }
}
