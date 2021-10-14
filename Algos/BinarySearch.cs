namespace Algos
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            var low = 0;
            var high = nums.Length - 1;

            while (low <= high)
            {
                int mid = low + ((high - low) / 2);
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }

        public bool IsBadVersion(int n)
        {
            // custom logic
            return n % 2 == 0;
        }

        public int FirstBadVersion(int n)
        {
            var left = 0;
            var right = n;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (IsBadVersion(mid))
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        public int SearchInsert(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = low + ((high - low) / 2);

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return high + 1;
        }
    }
}