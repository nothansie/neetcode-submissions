public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();
        var subset = new List<int>();

        Dfs(0);
        return result;

        void Dfs(int index){
            if(index >= nums.Length){
                result.Add(new List<int>(subset));
                return;
            }
            subset.Add(nums[index]);
            Dfs(index + 1);

            subset.RemoveAt(subset.Count - 1);
            Dfs(index + 1);
        }  
    }
}
