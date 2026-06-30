public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var adjacencyList = new Dictionary<int, List<int>>();
        var visited = new HashSet<int>();
        for(int i = 0; i < prerequisites.Length; i++){
            if(adjacencyList.ContainsKey(prerequisites[i][0])){
                adjacencyList[prerequisites[i][0]].Add(prerequisites[i][1]);
            } else {
                adjacencyList[prerequisites[i][0]] = new List<int>{prerequisites[i][1]};
            }
        }

        for(int i = 0; i < prerequisites.Length; i++){
            if(!Traverse(prerequisites[i][0])){
                return false;
            }
        }
        return true;

        bool Traverse(int course){
            if(visited.Contains(course)){
                return false;
            } else if(!adjacencyList.ContainsKey(course) || adjacencyList[course].Count == 0) {
                return true;
            }

            visited.Add(course);
            for(int i = 0; i < adjacencyList[course].Count; i++){
                var completable = Traverse(adjacencyList[course][i]); 
                if(!completable){
                    return false;
                }
            }
            visited.Remove(course);
            adjacencyList[course] = new List<int>();
            return true;
        }
    }
}
