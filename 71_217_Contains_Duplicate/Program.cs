public class Solution
{
    public static bool ContainsDuplicate(int[] nums)
    {
        return nums.Distinct().Count() != nums.Length;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4 };

        int[] arr2 = { 9, 5, 1, 2 };

        bool result = ContainsDuplicate(arr2);
    }
}