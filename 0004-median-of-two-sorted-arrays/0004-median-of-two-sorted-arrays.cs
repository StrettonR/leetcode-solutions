public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] combined = nums1.Concat(nums2).ToArray();
        int[] sortedCopy = combined.OrderBy(x => x).ToArray();
        if (sortedCopy.Count() == 0) return 0;
        if (sortedCopy.Count() == 1) return sortedCopy[0];
        var midValue = sortedCopy.Count() / 2;
        if (sortedCopy.Count() % 2 == 0) {
            double x = sortedCopy[midValue - 1];
            double y = sortedCopy[midValue];
            return (x + y) / 2; 
        } else {
            return sortedCopy[(midValue)];
        }
    }
}