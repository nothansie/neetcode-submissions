public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";
        for(int i = 0; i < strs.Count; i++){
            var currentStr = strs[i];
            string indicator = currentStr.Length.ToString() + "#"; 
            encoded = encoded + indicator + currentStr;
        }
        return encoded;
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int slow = 0;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '#'){
                var length = int.Parse(s[slow..i]);
                var str = s[(i+1)..(i+1+length)];
                result.Add(str);
                slow = i+1+length;
                i = slow - 1;
            }
        }
        return result;
   }
}
