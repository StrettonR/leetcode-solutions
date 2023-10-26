public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if (nums == null || target == null || nums.Length < 1) {
            return 0;
        }
        for(var i = 0; i < nums.Length; i++) {
            if (nums[i] >= target) {
                return i;
            }
        }
        return nums.Length;
    }
}