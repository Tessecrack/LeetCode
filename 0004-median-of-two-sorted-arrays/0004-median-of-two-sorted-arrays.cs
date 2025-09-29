public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int length = nums1.Length + nums2.Length;
        int[] mergedArray = new int[length];
        for (int i = 0, j = 0, k = 0; i < length / 2 + 1; ++i)
        {
            if (k < nums2.Length && (j >= nums1.Length || nums1[j] > nums2[k]))
            {
                mergedArray[i] = nums2[k++];
            }
            else if (j < nums1.Length && (k >= nums2.Length || nums1[j] < nums2[k]))
            {
                mergedArray[i] = nums1[j++];
            }
            else if (nums1[j] == nums2[k])
            {
                mergedArray[i++] = nums1[j++];
                mergedArray[i] = nums2[k++];
            }
        }
        return GetMedian(mergedArray);
    }

    private static double GetMedian(int[] nums)
    {
        var middle = nums.Length / 2;
        return nums.Length % 2 == 0 ? (nums[middle - 1] + (double)nums[middle]) / 2 : nums[middle];
    }
}