public class Solution {
    public int ArraySign(int[] nums) {
        if (nums == null || nums.Length == 0 || nums[0] == 0) {
            return 0;
        }
        var output = 1;
        foreach (var num in nums) {
            if (num == 0) {
                return 0;
            }
            if (num < 0) {
                output *= -1;
            }
        }
        return output;
    }
}
