public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 1){
            return nums[0];
        }
        return Math.Max(RobMaxValue(nums[0..^1]), RobMaxValue(nums[1..^0]));
    }

    int RobMaxValue(int[] robNums){
        var robOne = 0;
        var robTwo = 0;

        for(int i = 0; i < robNums.Length; i++){
            var temp = Math.Max(robNums[i] + robOne, robTwo);
            robOne = robTwo;
            robTwo = temp;
        }
        return robTwo;
    }
}
