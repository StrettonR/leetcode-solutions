public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        return this.FindIndices(nums, target);
    }
    
    public int [] FindIndices(int[] nums, int target) {
        for(var i = 0; nums.Length > i; i++) {
                for(var j = 0; nums.Length > j; j++) {
                    if (nums[i] + nums[j] == target && i != j) {
                        return new int [] {i,j}; 
                    }
                }
            }
        return new int [] {-1,-1};
    }
}