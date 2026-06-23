public class Solution {

    public string Encode(IList<string> strs) {
        var encoded = new StringBuilder();
        for(int i = 0; i < strs.Count; i++){
            var currentStr = strs[i];
            encoded.Append(currentStr.Length).Append('#').Append(currentStr);
        }
        return encoded.ToString();
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
