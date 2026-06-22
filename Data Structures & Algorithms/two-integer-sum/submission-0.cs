public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> differences = new();

        for(int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];
            if(differences.ContainsKey(diff)){
                return[differences[diff], i];
            } else {
                differences[nums[i]] = i;
            }
        }
        return [0,0];
    }
}
