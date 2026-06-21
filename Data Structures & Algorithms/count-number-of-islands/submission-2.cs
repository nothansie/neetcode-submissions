public class Solution {
    public int NumIslands(char[][] grid) {

        int width = grid[0].Length;
        int length = grid.Length;
        int islandCount = 0;

        HashSet<(int x, int y)> visited = new HashSet<(int x, int y)>();

        for(int y = 0; y < length; y++){
            for(int x = 0; x < width; x++){
                if(!visited.Contains((x, y))){
                    if(grid[y][x] == '1'){
                        TraverseIsland(x, y);
                        islandCount++;
                    }
                }
            }
        }

        return islandCount;

        bool TraverseIsland(int x, int y){
            Queue<(int x, int y)> gridSearch = new Queue<(int x, int y)>();
            
            gridSearch.Enqueue((x, y));
            visited.Add((x, y));

            while(gridSearch.Count > 0){
                var currentTile = gridSearch.Dequeue();
                int currX = currentTile.Item1;
                int currY = currentTile.Item2;
                
                var upY = currY + 1;
                var rightX = currX + 1;
                var downY = currY - 1;
                var leftX = currX - 1;

                //up
                if(0 <= upY && upY <= length - 1){
                    if(!visited.Contains((currX,upY)) && grid[upY][currX] == '1'){
                        gridSearch.Enqueue((currX, upY));
                        visited.Add((currX, upY));
                    }
                }

                //right
                if(0 <= rightX && rightX <= width - 1){
                    if(!visited.Contains((rightX,currY)) && grid[currY][rightX] == '1'){
                        gridSearch.Enqueue((rightX, currY));
                        visited.Add((rightX, currY));
                    }
                }

                //down
                if(0 <= downY && downY <= length - 1){
                    if(!visited.Contains((currX,downY)) && grid[downY][currX] == '1'){
                        gridSearch.Enqueue((currX, downY));
                        visited.Add((currX, downY));
                    }
                }

                //left
                if(0 <= leftX && leftX <= width - 1){
                    if(!visited.Contains((leftX,currY)) && grid[currY][leftX] == '1'){
                        gridSearch.Enqueue((leftX, currY));
                        visited.Add((leftX, currY));
                    }
                }
            }
            return true;
        }
    }
}
