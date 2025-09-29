public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length == 0)
        {
            return GetMedian(nums2);
        }
        if (nums2.Length == 0)
        {
            return GetMedian(nums1);
        }
        var mergedArray = MergeSortedArray(nums1, nums2);
        ShowArray(mergedArray);
        return GetMedian(mergedArray);
    }

    private double GetMedian(int[] nums)
    {
        if (nums.Length % 2 != 0)
        {
            return nums[nums.Length / 2];
        }
        else
        {
            var middle = nums.Length / 2;
            return (nums[middle - 1] + (double)nums[middle]) / 2;
        }
    }

    private int[] MergeSortedArray(int[] nums1, int[] nums2)
    {
        int length = nums1.Length + nums2.Length;

        var mergedArray = new int[length];
        for (int i = 0, nums1Counter = 0, nums2Counter = 0; i < length / 2 + 1; ++i)
        {
            if (nums1Counter >= nums1.Length && nums2Counter < nums2.Length)
            {
                mergedArray[i] = nums2[nums2Counter++];
                continue;
            }
            else if (nums2Counter >= nums2.Length && nums1Counter < nums1.Length)
            {
                mergedArray[i] = nums1[nums1Counter++];
                continue;
            }

            if (nums1[nums1Counter] < nums2[nums2Counter])
            {
                mergedArray[i] = nums1[nums1Counter++];
            }
            else if (nums1[nums1Counter] > nums2[nums2Counter])
            {
                mergedArray[i] = nums2[nums2Counter++];
            }
            else
            {
                mergedArray[i++] = nums1[nums1Counter++];
                mergedArray[i] = nums2[nums2Counter++];
            }
        }

        return mergedArray;
    }

    private void ShowArray(int[] arr)
    {
        foreach (var el in arr)
        {
            Console.Write(el + " ");
        }
    }
}