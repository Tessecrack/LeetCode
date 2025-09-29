public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var mergedArr = nums1.Concat(nums2).ToArray();
        Array.Sort(mergedArr);
        if (mergedArr.Length % 2 != 0)
        {
            return mergedArr[mergedArr.Length / 2];
        }
        else
        {
            var middle = mergedArr.Length / 2;
            return (mergedArr[middle - 1] + (double)mergedArr[middle]) / 2;
        }
    }
}