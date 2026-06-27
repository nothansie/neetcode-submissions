public class Solution {
    public bool Exist(char[][] board, string word) {
        
        bool Search(int x, int y, int charIndex){
            if(charIndex >= word.Length ){
                return true;
            }
            var temp = board[y][x]; 
            board[y][x] = '#';
            if(y > 0){
                if(board[y - 1][x] == word[charIndex]){
                    if(Search(x, y - 1, charIndex + 1)){
                        return true;
                    }
                }
            }
            if(y < board.Length - 1){
                if(board[y + 1][x] == word[charIndex]){
                    if(Search(x, y + 1, charIndex + 1)){
                        return true;
                    }
                }
            }
            if(x > 0){
                if(board[y][x - 1] == word[charIndex]){
                    if(Search(x - 1, y, charIndex + 1)){
                        return true;
                    }
                }
            }
            if(x < board[0].Length - 1){
                if(board[y][x + 1] == word[charIndex]){
                    if(Search(x + 1, y, charIndex + 1)){
                        return true;
                    }
                }
            }
            board[y][x] = temp;
            return false;
        }

        for(var y = 0; y < board.Length; y++){
            for(var x = 0; x < board[0].Length; x++){
                if(board[y][x] == word[0]){
                    if(word.Length == 1){
                        return true;
                    }
                    if (Search(x, y, 1)){
                        return true;
                    }
                }
            }
        }
        return false;
    }
}
