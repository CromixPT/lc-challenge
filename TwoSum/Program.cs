// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] nums1 = new int[] { 2, 7, 11, 15 };
int target1 = 9;

int[] nums2 = new int[] { 3, 2, 4 };
int target2 = 6;

int[] nums3 = new int[] { 3, 3 };
int target3 = 6;

var result = Solution.TwoSum(nums1, target1);
var result2 = Solution.TwoSum(nums2, target2);
var result3 = Solution.TwoSum(nums3, target3);

Console.WriteLine("Results 1: [{0}]", string.Join(", ", result));
Console.WriteLine("Results 2: [{0}]", string.Join(", ", result2));
Console.WriteLine("Results 3: [{0}]", string.Join(", ", result3));



public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
                return new int[] { i, dict[target - nums[i]] };

            dict[nums[i]] = i;
        }
        return new int[2];
    }
}