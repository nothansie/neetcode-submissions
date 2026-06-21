public class Solution {
    public int FindMin(int[] nums) {
        int leftPointer = 0;
        int rightPointer = nums.Length - 1;

        int minimumIndex = 0;
        while(leftPointer <= rightPointer){
            int midPointer = (leftPointer + rightPointer) / 2;

            if(nums[midPointer] <= nums[nums.Length - 1]){
                rightPointer = midPointer - 1;
                minimumIndex = midPointer;
            } else {
                leftPointer = midPointer + 1;
            }
        }

        return nums[minimumIndex];
    }
}
