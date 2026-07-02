public class Solution {
    public int Rob(int[] nums) {
        var robOne = 0;
        var robTwo = 0;

        for(int i = 0; i < nums.Length; i++){
            var temp = Math.Max(nums[i] + robOne, robTwo);
            robOne = robTwo;
            robTwo = temp;
        }
        return robTwo;
    }
}
