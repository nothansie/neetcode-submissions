public class Solution {
    public int NumDecodings(string s) {
        if(s[0] == '0'){
            return 0;
        }

        int[] lookup = new int[s.Length + 1];

        lookup[0] = 1;
        lookup[1] = 1;

        for(int i = 2; i <= s.Length; i++){
            if (s[i - 1] != '0') {
                lookup[i] += lookup[i - 1];
            }

            int twoDigits = int.Parse(s[(i - 2)..i]);
            if (twoDigits >= 10 && twoDigits <= 26) {
                lookup[i] += lookup[i - 2];
            }
        }

        return lookup[s.Length];
    }
}
