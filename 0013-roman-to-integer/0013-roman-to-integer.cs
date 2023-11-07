public class Solution {
    public int RomanToInt(string s) {
        var result = 0;
        var previousValue = '#';
        for (var i = 0; i < s.Length; i++) {
            switch (s[i]) {
            case 'I':
                result += 1;
                break;
            case 'V':
                if (previousValue == 'I') {
                    result += 3;
                } else {
                    result += 5;
                }
                break;
            case 'X':
                if (previousValue == 'I') {
                    result += 8;
                } else {
                    result += 10;
                }
                break;
            case 'L':
                if (previousValue == 'X') {
                    result += 30;
                } else {
                    result += 50;
                }
                break;
            case 'C':
                if (previousValue == 'X') {
                    result += 80;
                } else {
                    result += 100;
                }
                break;
            case 'D':
                if (previousValue == 'C') {
                    result += 300;
                } else {
                    result += 500;
                }
                break;
            case 'M':
                if (previousValue == 'C') {
                    result += 800;
                } else {
                    result += 1000;
                }
                break;
            }
            previousValue = s[i];
        }
        return result;
    }
}