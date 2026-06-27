public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var result = new List<List<int>>();
        
        void dfs(int index, List<int> currentCombination, int currentValue){
            if(currentValue == target){
                result.Add(new List<int>(currentCombination));
                return;
            }
            if(index >= nums.Length || currentValue > target){
                return;
            }
            currentCombination.Add(nums[index]);
            dfs(index, currentCombination, (currentValue + nums[index]));
            currentCombination.RemoveAt(currentCombination.Count - 1);
            dfs(index + 1, currentCombination, currentValue);
        }

        dfs(0, new List<int>(), 0);
        return result;
    }
}
