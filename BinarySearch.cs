public static class BinarySearch
{
    public static int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int middle = 0;

        while (left <= right)
        {
            middle = left + (right - left) / 2;

            if (nums[middle] == target) return middle;

            if (nums[middle] >= nums[left])
            {
                if (target >= nums[left] && target < nums[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            else
            {
                if (target <= nums[right] && target > nums[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

        }

        return -1;
    }
}