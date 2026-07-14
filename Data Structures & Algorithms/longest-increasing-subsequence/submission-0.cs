public class Solution {
    public int LengthOfLIS(int[] nums) {
        var lookup = new Dictionary<(int, int), int>();
        return Longest(0, int.MinValue);

        int Longest(int index, int minValue){
            if(index >= nums.Length){
                return 0;
            }
            if(lookup.ContainsKey((index, minValue))){
                return lookup[(index, minValue)];
            }
            var longest = 0;
            if(nums[index] > minValue){
                longest = Math.Max(
                    Longest(index + 1, minValue),
                    1 + Longest(index + 1, nums[index])
                );
            } else {
                longest = Longest(index + 1, minValue);
            }
            lookup[(index, minValue)] = longest;
            return longest;
        }
    }
}
