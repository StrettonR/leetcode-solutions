public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        var result = -1;
        var words = sentence.Split(' ');
        for (var i = 0; i < words.Length; i++) {
            if (words[i].StartsWith(searchWord)) { 
                result = i + 1;
                break;
            }
        }
        return result;
    }
}