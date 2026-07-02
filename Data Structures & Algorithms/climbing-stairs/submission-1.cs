public class Solution {
    public int ClimbStairs(int n) {
        var one = 1;
        var two = 1;

        for(int i = 0; i < n - 1; i++){
            var newTwo = two + one;
            one = two;
            two = newTwo;
        }
        return two;
    }
}
