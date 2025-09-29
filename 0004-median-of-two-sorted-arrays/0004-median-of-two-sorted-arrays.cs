public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int length = nums1.Length + nums2.Length;
        int previousLastElement = 0, lastElement = 0;
        bool canSkip = false;
        for (int i = 0, j = 0, k = 0; i < length / 2 + 1; ++i)
        {
            if (canSkip)
            {
                previousLastElement = lastElement;
                canSkip = false;
                continue;
            }
            if (k < nums2.Length && (j >= nums1.Length || nums1[j] > nums2[k]))
            {
                previousLastElement = lastElement;
                lastElement = nums2[k++];
            }
            else if (j < nums1.Length && (k >= nums2.Length || nums1[j] < nums2[k]))
            {
                previousLastElement = lastElement;
                lastElement = nums1[j++];
            }
            else if (nums1[j] == nums2[k])
            {
                lastElement = nums1[j++];
                k++;
                canSkip = true;
            }
        }
        return length % 2 == 0 ? (lastElement + (double)previousLastElement) / 2 : lastElement;
    }
}