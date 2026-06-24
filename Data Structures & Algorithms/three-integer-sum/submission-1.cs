public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        var output = new List<List<int>>();

        for(int i = 0; i < nums.Length; i++){
            if(i > 0 && nums[i] == nums[i - 1]){
                continue;
            }
            var left = i + 1;
            var right = nums.Length - 1;
            while(left < right){
                var threeSum = nums[i] + nums[left] + nums[right];
                if(threeSum > 0){
                    right--;
                } else if(threeSum < 0){
                    left++;
                } else {
                    output.Add(new List<int>{nums[i], nums[left], nums[right]});
                    left++;
                    while(nums[left] == nums[left - 1] && left < right){
                        left++;
                    }
                }
            }
        }

        return output;
    }
}
