public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int fastestSpeed = right;
        while(left <= right){
            int mid = (left + right) / 2;
            if(totalHours(mid) <= h){
                fastestSpeed = mid;
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        return fastestSpeed;

        long totalHours(int speed){
            long total = 0;
            for(int i = 0; i < piles.Length; i++){
                if(piles[i] % speed == 0){
                    total += piles[i] / speed;
                } else {
                    total += (piles[i] / speed) + 1;
                }
            }
            return total;
        }
    }
}
