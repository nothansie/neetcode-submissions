public class Solution {
    public int Rob(int[] nums) {
        var cache = new Dictionary<int, int>();
        
        if(nums.Length == 1){
            return nums[0];
        }
        
        return Math.Max(Search(0), Search(1));
        
        int Search(int index){
            if(cache.ContainsKey(index)){
                return cache[index];
            }

            var value = nums[index];
            if(index + 3 < nums.Length){
                value += Math.Max(Search(index + 2), Search(index + 3));
            } else if(index + 2 < nums.Length) {
                value += Search(index + 2);
            }
            cache[index] = value;
            return value;
        }
    }
}
