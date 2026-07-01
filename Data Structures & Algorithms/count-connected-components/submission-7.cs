public class Solution {
    public int CountComponents(int n, int[][] edges) {
        var adjList = new Dictionary<int, List<int>>();
        var visited = new HashSet<int>();
        var connectedComponents = 0;

        for(int i = 0; i < edges.Length; i++){
            if(adjList.ContainsKey(edges[i][0])){
                adjList[edges[i][0]].Add(edges[i][1]);
            } else {
                adjList[edges[i][0]] = new List<int>{ edges[i][1] };
            }
            if(adjList.ContainsKey(edges[i][1])){
                adjList[edges[i][1]].Add(edges[i][0]);
            } else {
                adjList[edges[i][1]] = new List<int>{ edges[i][0] };
            }
        }

        foreach(var node in adjList){
            if(!visited.Contains(node.Key)){
                connectedComponents++;
                for(int i = 0; i < node.Value.Count; i++){
                    if(!visited.Contains(node.Value[i])){
                        TraverseNode(node.Key, -1);
                    }
                }
            }
        }
        connectedComponents += n - adjList.Count;
        return connectedComponents;

        void TraverseNode(int nodeKey, int parentKey){
            if(visited.Contains(nodeKey)){
                return;
            }
            visited.Add(nodeKey);
            for(int i = 0; i < adjList[nodeKey].Count; i++){
                if(!visited.Contains(adjList[nodeKey][i]) && adjList[nodeKey][i] != parentKey){
                    TraverseNode(adjList[nodeKey][i], nodeKey);
                }
            }
        }
    }
}
