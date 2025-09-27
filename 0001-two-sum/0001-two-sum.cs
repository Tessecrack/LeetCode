public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            var num = nums[i];
            if (dict.TryGetValue(num, out var val))
            {
                return [val, i];
            }
            dict.TryAdd(target - nums[i], i);
        }
        return [];
    }
}