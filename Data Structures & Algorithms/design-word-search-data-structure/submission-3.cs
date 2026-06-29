public class WordDictionary {
    TrieNode root;
    public WordDictionary() {
        root = new TrieNode('#');
    }
    
    public void AddWord(string word) {
        var currentNode = root;
        for(var i = 0; i < word.Length; i++){
            var existingNode = currentNode.FindChild(word[i]);
            if(existingNode == null){
                currentNode = currentNode.AddChild(word[i]);
            } else {
                currentNode = existingNode;
            }
        }
        currentNode.IsEndOfWord = true;
    }
    
    public bool Search(string word){
        return SearchNode(word, root);
    }

    public bool SearchNode(string word, TrieNode startingNode) {
        var currentNode = startingNode;
        for(var i = 0; i < word.Length; i++){
            if(word[i] == '.'){
                if(i == word.Length - 1){
                    for(var k = 0; k < currentNode.Children.Count; k++){
                        if(currentNode.Children[k].IsEndOfWord){
                            return true;
                        }
                    }
                    return false;
                } else {
                    for(var k = 0; k < currentNode.Children.Count; k++){
                        var truncatedWord = word[(i + 1)..^0];
                        if(SearchNode(truncatedWord, currentNode.Children[k]) == true){
                            return true;
                        }
                    }
                    return false;
                }
            } else {
                var existingChild = currentNode.FindChild(word[i]);
                if(existingChild != null){
                currentNode = existingChild; 
                } else {
                    return false;
                }
            }
        }
        if(currentNode.IsEndOfWord){
            return true;
        } else {
            return false;
        }
    }
}

public class TrieNode(char value, bool isEndOfWord = false){
    public char Value = value;
    public bool IsEndOfWord = isEndOfWord;
    public List<TrieNode> Children = new List<TrieNode>();

    public TrieNode? FindChild(char value){
        for(var i = 0; i < Children.Count; i++){
            if(Children[i].Value == value){
                return Children[i];
            }
        }
        return null;
    }

    public TrieNode AddChild(char value, bool isEndOfWord = false){
        var newNode = new TrieNode(value, isEndOfWord);
        Children.Add(newNode);
        return newNode;
    }
}