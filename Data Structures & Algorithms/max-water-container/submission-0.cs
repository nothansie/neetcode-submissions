public class Solution {
    public int MaxArea(int[] heights) {
        var maxArea = 0;

        var left = 0;
        var right = heights.Length - 1;

        while(left < right){
            if(heights[right] < heights[left]){
                var newMaxArea = heights[right] * (right - left);
                maxArea = Math.Max(newMaxArea, maxArea);
                right--;
            } else {
                var newMaxArea = heights[left] * (right - left);
                maxArea = Math.Max(newMaxArea, maxArea);
                left++;
            }
        }

        return maxArea;
    }
}
