public class Solution {
    public int ArraySign(int[] nums) {
        var output = 1;
        if (nums.Contains(0)) {
            return 0;
        }
        foreach (var i in nums) {
            output *= signFunc(i);
        }
        return output;
    }

    public int signFunc(int x) {
        if (x == 0) return 0;
        if (x < 0) return -1;
        return 1;
    }
}