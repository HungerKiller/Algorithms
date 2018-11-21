namespace LeetCode
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            result[0] = 0;
            foreach (var num in nums)
            {
                for (result[1] = result[0] + 1; result[1] < nums.Length; result[1]++)
                {
                    if (nums[result[1]] == target - num)
                        return result;
                }
                result[0]++;
            }
            return result;
        }
    }
}
