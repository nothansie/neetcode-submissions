public class Solution {    
    public int CoinChange(int[] coins, int amount) {
        int[] lookup = new int[amount + 1];
        lookup[0] = 0;
        for(int i = 1; i <= amount; i++){
            lookup[i] = amount + 1;
        }

        for(int i = 1; i <= amount; i++){
            for(int k = 0; k < coins.Length; k++){
                if(i - coins[k] >= 0){
                    lookup[i] = Math.Min(lookup[i], 1 + lookup[i - coins[k]]);
                }
            }
        }
        if(lookup[amount] != amount + 1){
            return lookup[amount];
        } else {
            return -1;
        }
    }
}
