public class Solution {
    public bool IsPalindrome(int x) {
        var xAsString = x.ToString();
        char firstValue = xAsString[0];
        if ('-'.CompareTo(firstValue) == 0) {
            return false;
        }

        if (x > 1) {
            for (var i = 0; i < xAsString.Length; i++) {
                if (xAsString[i] != xAsString[xAsString.Length - i - 1]) {
                    return false;
                }

            }
        }
            return true;
    }
}