public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        var pacificFlow = new HashSet<(int y, int x)>();
        var atlanticFlow = new HashSet<(int y, int x)>();

        for(int y = 0; y < heights.Length; y++){
            for(int x = 0; x < heights[0].Length; x++){
                if(x == 0 || y == 0){
                    TraverseFlow((y,x), 0, pacificFlow);    
                }
            }   
        }

        for(int y = 0; y < heights.Length; y++){
            for(int x = 0; x < heights[0].Length; x++){
                if(x == heights[0].Length - 1 || y == heights.Length - 1){
                    TraverseFlow((y,x), 0, atlanticFlow);    
                }
            }   
        }
        
        var result = new List<List<int>>();
        foreach(var coordinate in pacificFlow){
            if(atlanticFlow.Contains(coordinate)){
                var coordinates = new List<int>();
                coordinates.Add(coordinate.y);
                coordinates.Add(coordinate.x);
                result.Add(coordinates);
            }
        }
        return result;

        void TraverseFlow((int y, int x) position, int lastHeight, HashSet<(int y, int x)> visited){
            var currentHeight = heights[position.y][position.x];
            if(currentHeight >= lastHeight && !visited.Contains(position)){
                visited.Add(position);

                if(position.y > 0){
                    TraverseFlow((position.y - 1, position.x), currentHeight, visited);
                }
                if(position.y < heights.Length - 1){
                    TraverseFlow((position.y + 1, position.x), currentHeight, visited);
                }
                if(position.x > 0){
                    TraverseFlow((position.y, position.x - 1), currentHeight, visited);
                }
                if(position.x < heights[0].Length - 1){
                    TraverseFlow((position.y, position.x + 1), currentHeight, visited);
                }
            }
        }
    }
}
