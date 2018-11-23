using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Solution
    {
        #region Problem 1

        // Basic
        public static int[] TwoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return null;
        }

        // Have issue "Memory Limit Exceeded"
        public static int[] TwoSum2(int[] nums, int target)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int num2 = target - nums[i];
                nums = nums.Take(nums.Length - 1).ToArray(); // Take need more memory
                if (nums.Contains(num2))
                    return new int[] { nums.ToList().IndexOf(num2), i };
            }
            return null;
        }

        // OK
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> indexAndNum = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num2 = target - nums[i];
                if (indexAndNum.ContainsValue(num2))
                    return new int[] { indexAndNum.FirstOrDefault(item => item.Value == num2).Key, i };
                indexAndNum.Add(i, nums[i]);
            }
            return null;
        }

        #endregion Problem 1

        #region Problem 2

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;
            if (l1 == null)
                l1 = new ListNode(0);
            if (l2 == null)
                l2 = new ListNode(0);
            ListNode listNode = new ListNode(l1.val + l2.val);
            if (listNode.val >= 10)
            {
                listNode.val -= 10;
                if (l1.next == null)
                    l1.next = new ListNode(1);
                else
                    l1.next.val++;
            }
            listNode.next = AddTwoNumbers(l1.next, l2.next);
            return listNode;
        }

        #endregion Problem 2

        #region Problem 3

        public static int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            List<char> charList = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                for(int j = i; j < s.Length; j++)
                {
                    if (charList.Contains(s[j]))
                    {
                        length = (length < charList.Count()) ? charList.Count() : length;
                        charList.Clear();
                        break;
                    }
                    charList.Add(s[j]);
                }
            }
            length = (length < charList.Count()) ? charList.Count() : length;
            return length;
        }

        #endregion Problem 3

        #region Problem 4

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            return 0;
        }

        #endregion Problem 4
    }
}
