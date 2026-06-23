public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int left = 0;
        int right = 1;

        while(right < prices.Length){
            var currentDifference = prices[right] - prices[left];
            maxProfit = Math.Max(maxProfit, currentDifference);

            if(prices[right] < prices[left]){
                left = right; 
            }
            right++;
        }
        return maxProfit;
    }
}
