public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        var adjList = new Dictionary<int, List<int>>();
        var visited = new HashSet<int>();

        if (n <= 1){
            if(edges.Length == 0){
                return true;
            } else {
                return false;
            }
        }; 

        foreach(var edge in edges){
            if (adjList.ContainsKey(edge[0])){
                adjList[edge[0]].Add(edge[1]);
            } else {
                adjList[edge[0]] = new List<int> {edge[1]};
            }
            if (adjList.ContainsKey(edge[1])){
                adjList[edge[1]].Add(edge[0]);
            } else {
                adjList[edge[1]] = new List<int> {edge[0]};
            }
        }

        if(!ValidNode(edges[0][0], -1) || visited.Count != n){
            return false;
        }

        return true;

        bool ValidNode(int key, int parentKey){
            visited.Add(key);
            var neighbours = adjList[key];
            foreach(var neighbour in neighbours){
                if(neighbour != parentKey){
                    if(visited.Contains(neighbour) || !ValidNode(neighbour, key)){
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
