public static class Binary2DSearch
{
    public static bool Search(int[,] nums, int target)
    {
        var left = 0;
        var right = nums.GetLength(1) - 1;

        while (left < right)
        {
            if (nums[left, right] < target)
            {
                left++;
                continue;
            }

            if (nums[left, 0] > target) return false;

            break; // ENCONTRE DONDE PUEDE ESTAR
        }

        int row = left;
        left = 0;



        while (left <= right)
        {
            int middle = left + (right - left) / 2;
            if (nums[row, middle] == target) return true;

            if (nums[row, middle] < target) left = middle + 1;
            else right = middle - 1;
        }

        return false;
    }
}