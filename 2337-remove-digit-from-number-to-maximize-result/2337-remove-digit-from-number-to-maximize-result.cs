public class Solution {
    public string RemoveDigit(string number, char digit) {
        var index = 0;
        for (var i = 0; i < number.Length; i++) {
            if (number[i] == digit) {
                index = i;
                if ((i + 1) < number.Length) {
                    if (digit < number[i + 1]) {
                        break;
                    }
                }
            }
        }
        return number.Remove(index, 1);
    }
}