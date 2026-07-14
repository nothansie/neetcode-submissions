public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var numbersEncountered = new HashSet<char>();

        //validate row
        for(int y = 0; y < board.Length; y++){    
            numbersEncountered.Clear();
            for(int x = 0; x < board[y].Length; x++){
                if(board[y][x] == '.'){
                    continue;
                }
                if(numbersEncountered.Contains(board[y][x])){
                    return false;
                } else {
                    numbersEncountered.Add(board[y][x]);
                }
            }
        }

        //validate column
        for(int x = 0; x < board[0].Length; x++){    
            numbersEncountered.Clear();
            for(int y = 0; y < board.Length; y++){
                if(board[y][x] == '.'){
                    continue;
                }
                if(numbersEncountered.Contains(board[y][x])){
                    return false;
                } else {
                    numbersEncountered.Add(board[y][x]);
                }
            }
        }

        //validate box
        for(int boxY = 1; boxY < 4; boxY++){
            for(int boxX = 1; boxX < 4; boxX++){
                var startingY = 9 - (boxY * 3);
                var startingX = 9 - (boxX * 3);
                numbersEncountered.Clear();

                for(int y = startingY; y < startingY + 3; y++){
                    for(int x = startingX; x < startingX + 3; x++){
                        if(board[y][x] == '.'){
                            continue;
                        }
                        if(numbersEncountered.Contains(board[y][x])){
                            return false;
                        } else {
                            numbersEncountered.Add(board[y][x]);
                        }
                    }  
                }
            }            
        }

        return true;
    }
}
