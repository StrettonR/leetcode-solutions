public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if (nums == null || nums.Count() <= 1) {
            return false;
        }
        var result = new HashSet<int>();
        foreach (var i in nums) {
            if (!result.Add(i)) {
                return true;
            }
        }
        return false;
    }
}