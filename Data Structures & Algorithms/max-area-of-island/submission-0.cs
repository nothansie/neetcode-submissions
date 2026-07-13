public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        for(int y = 0; y < grid.Length; y++){
            for(int x = 0; x < grid[y].Length; x++){
                if(grid[y][x] == 1){
                    var islandArea = TraverseIsland(y, x);
                    maxArea = Math.Max(islandArea, maxArea);
                }
                grid[y][x] = 2;
            }
        }

        return maxArea;

        int TraverseIsland(int y, int x){
            if(grid[y][x] != 1){
                return 0;
            }
            var buffer = 1;
            grid[y][x] = 2;
            if(y < grid.Length - 1){
                buffer += TraverseIsland(y + 1, x);
            }
            if(y > 0){
                buffer += TraverseIsland(y - 1, x);
            }
            if(x < grid[y].Length - 1){
                buffer += TraverseIsland(y, x + 1);
            }
            if(x > 0){
                buffer += TraverseIsland(y, x - 1);
            }

            return buffer;
        }
    }
}
