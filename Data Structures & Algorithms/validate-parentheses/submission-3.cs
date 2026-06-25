public class Solution {
    public bool IsValid(string s) {
        var parTracker = new Stack<char>();
        for(int i = 0; i < s.Length; i++){
            var currentChar = s[i];
            if(currentChar == '('){
                parTracker.Push(')');
            } else if(currentChar == '{'){
                parTracker.Push('}');
            } else if(currentChar == '['){
                parTracker.Push(']');
            } else {
                if(parTracker.Count != 0){
                    var nextPar = parTracker.Pop();
                    if(nextPar != currentChar){
                        return false;
                    }
                } else {
                    return false;
                }
            }
        }
        if(parTracker.Count == 0){
            return true;
        } else {
            return false;
        }
    }
}
