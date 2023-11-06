public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;
        var left = 0;
        var right = 1;
        while (right < prices.Length) {
            if (prices[left] > prices[right]) {
                left = right;
            } else {
                var profit = prices[right] - prices[left];
                maxProfit = profit > maxProfit ? profit : maxProfit;
            }
            right++;
        }
        return maxProfit;
    }
}