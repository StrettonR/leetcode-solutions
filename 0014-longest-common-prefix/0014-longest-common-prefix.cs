public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var result = "";
        if (strs.Length < 1 || strs[0].Length < 1) {
            return result;
        }
        if (strs.Length == 1) { 
            return strs[0];
        }
        var shortestString = strs[0].Length;
        foreach (var str in strs) {
            shortestString = str.Length < shortestString ? str.Length : shortestString;
        }
        for (var c = 0; c < shortestString; c++) {
            var charToCheck = strs[0][c];
            for (var s = 1; s < strs.Length; s++) {
                if (strs[s][c] != charToCheck) {
                    return result;
                }
            }
            result += charToCheck;
        }
        return result; 
    }
}