public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> intOcurrances = new HashSet<int>();

        foreach(int num in nums){
            if(intOcurrances.Contains(num)){
                return true;
            } else {
                intOcurrances.Add(num);
            }
        }

        return false;
    }
}