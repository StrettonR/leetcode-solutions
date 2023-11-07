public class Solution {
    public int RomanToInt(string s) {
        var result = 0;
        var num = 0;
        var previousValue = 0;
        for (var i = (s.Length -1); i >= 0; i--) {
            switch (s[i]) {
                case 'I': num = 1; break;
                case 'V': num = 5; break;
                case 'X': num = 10; break;
                case 'L': num = 50; break;
                case 'C': num = 100; break;
                case 'D': num = 500; break;
                case 'M': num = 1000; break;
            }
            result = num < previousValue ? result -= num : result += num;
            previousValue = num;
        }
        return result;
    }
}
