public class Solution {
    public int MaxProduct(int[] nums) {
        int maxProduct = int.MinValue;
        for(int i = 0; i < nums.Length; i++){
            maxProduct = Math.Max(maxProduct, GetMaxProduct(i, i));
        }
        if(maxProduct == int.MinValue){
            return 0;
        }
        return maxProduct;

        int GetMaxProduct(int startIndex, int endIndex){
            if(endIndex >= nums.Length){
                return int.MinValue;
            }
            int product = 1;
            for(int k = startIndex; k <= endIndex; k++){
                product = product * nums[k];
            }
            return Math.Max(product, GetMaxProduct(startIndex, endIndex + 1));
        }
    }
}
