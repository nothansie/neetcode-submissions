#nullable enable

public class PrefixTree {
    TrieNode rootNode;

    public PrefixTree() {
        rootNode = new TrieNode('#', false);
    }
    
    public void Insert(string word) {
        var currentNode = rootNode;

        for(var i = 0; i < word.Length; i++){
            var foundNode = currentNode.FindChild(word[i]);
            if(foundNode != null){
                currentNode = foundNode;
            } else {
                currentNode = currentNode.AddChild(word[i]); 
            }
            if(i == word.Length - 1){
                currentNode.IsEndOfWord = true;
            }
        }
    }
    
    public bool Search(string word) {
        var currentNode = rootNode;

        for(var i = 0; i < word.Length; i++){
            var foundNode = currentNode.FindChild(word[i]);
            if(foundNode != null){
                currentNode = foundNode;
                if(i == word.Length - 1 && currentNode.IsEndOfWord == true){
                    return true;
                }
            } else {
                return false;
            }
        }
        return false;
    }
    
    public bool StartsWith(string prefix) {
        var currentNode = rootNode;

        for(var i = 0; i < prefix.Length; i++){
            var foundNode = currentNode.FindChild(prefix[i]);
            if(foundNode != null){
                currentNode = foundNode;
            } else {
                return false;
            }
        }
        return true;
    }
}

public class TrieNode(char value, bool isEndOfWord){
    public char Value = value;
    public List<TrieNode> Children = new List<TrieNode>();
    public bool IsEndOfWord = isEndOfWord;

    public TrieNode? FindChild(char targetValue){
        for(int k = 0; k < Children.Count; k++){
            if(Children[k].Value == targetValue){
                return Children[k];
            }
        }
        return null;
    }

    public TrieNode AddChild(char newValue){
        var newChild = new TrieNode(newValue, false);
        Children.Add(newChild);
        return newChild;
    }
}