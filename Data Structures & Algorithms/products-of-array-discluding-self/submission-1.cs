public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefix = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            if(i == 0){
                prefix[i] = nums[i];
            } else {
                prefix[i] = prefix[i - 1] * nums[i];
            }
        }
        
        var postfix = new int[nums.Length];
        for(int i = nums.Length - 1; i >= 0; i--){
            if(i == nums.Length - 1){
                postfix[i] = nums[i];
            } else {
                postfix[i] = postfix[i + 1] * nums[i];
            }
        }

        var output = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            if(i == 0){
                output[i] = postfix[i + 1];
            } else if(i == nums.Length - 1){
                output[i] = prefix[i - 1];
            } else {
                output[i] = prefix[i - 1] * postfix[i + 1];
            }
        }

        return output;
    }
}
