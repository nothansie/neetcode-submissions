public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int leftBucket = 0;
        int rightBucket = matrix.Length - 1;
        int targetBucket = -1;
        int m = matrix[0].Length;
        while(leftBucket <= rightBucket){
            var midBucket = (leftBucket + rightBucket) / 2;
            if(target > matrix[midBucket][m - 1]){
                leftBucket = midBucket + 1;
            } else if(target < matrix[midBucket][0]){
                rightBucket = midBucket - 1;
            } else {
                targetBucket = midBucket;
                break;
            }
        }
        if(targetBucket == -1){
            return false;
        }

        int left = 0;
        int right = matrix[targetBucket].Length - 1;
        while(left <= right){
            var mid = (left + right) / 2;
            if(matrix[targetBucket][mid] == target){
                return true;
            } else if(target > matrix[targetBucket][mid]){
                left = mid + 1;
            } else if(target < matrix[targetBucket][mid]){
                right = mid - 1;
            }
        }
        return false;
    }
}
