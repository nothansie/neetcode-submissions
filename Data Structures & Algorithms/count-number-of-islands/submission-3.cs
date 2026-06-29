public class Solution {
    public int NumIslands(char[][] grid) {
        
        var islands = 0;
        var visited = new HashSet<(int y, int x)>();
        for(var y = 0; y < grid.Length; y++){
            for(var x = 0; x < grid[0].Length; x++){
                if(!visited.Contains((y, x))){
                    if(grid[y][x] == '1'){
                        TraverseIsland((y,x));
                        islands++;
                    }

                }
            }
        }

        return islands;

        void TraverseIsland((int y, int x) position){
            if(visited.Contains(position)){
                return;
            }
            visited.Add(position);
            if(grid[position.y][position.x] == '0'){
                return;
            }
            if(position.y > 0){
                TraverseIsland((position.y - 1, position.x));
            }
            if(position.y < grid.Length - 1){
                TraverseIsland((position.y + 1, position.x));
            }
            if(position.x > 0){
                TraverseIsland((position.y, position.x - 1));
            }
            if(position.x < grid[0].Length - 1){
                TraverseIsland((position.y, position.x + 1));
            }
        }
    }
}
