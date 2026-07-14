public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var lookup = new Dictionary<int, int>();
        
        return MinCost(-1);

        int MinCost(int index){
            if(index >= cost.Length){
                return 0;
            }
            if(lookup.ContainsKey(index)){
                return lookup[index];
            }
            int stepCost = 0;
            if(index >= 0){
                stepCost = cost[index];
            }
            int minCost = Math.Min(MinCost(index + 1) + stepCost, MinCost(index + 2) + stepCost);
            lookup[index] = minCost;
            return minCost;
        }
    }
}
