public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (String.IsNullOrEmpty(s)) {
            return 0;
        }

        var output = 1;
        var substring = "";
        for (var i = 0; i < s.Length; i++) {
            if (substring.Contains(s[i])) {
                if (substring.Length > 1) {
                    foreach (var c in substring) {
                        if (c.ToString().Equals(s[i].ToString())) {
                            substring = substring.Remove(0, 1);
                            break;
                        }
                        substring = substring.Remove(0, 1);
                    }
                    substring += s[i];
                }
            } else {
                substring += s[i];
                if (substring.Length > output) {
                    output = substring.Length;
                }
            }
        }
        return output;
    }
}