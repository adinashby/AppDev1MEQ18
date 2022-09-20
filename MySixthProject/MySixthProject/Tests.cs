using System;
namespace MySixthProject
{
    public class Tests
    {
        public static void Main(String[] args)
        {
            int[] input = { 0, 1, 1 };

            Console.WriteLine(FindMaxLength(input));

        }

        public static int FindMaxLength(int[] nums)
        {

            if (nums == null || nums.Length == 0)
                return 0;

            int max = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();

            dic.Add(0, -1);

            int prefixSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                prefixSum += nums[i] == 1 ? 1 : -1;

                if (dic.ContainsKey(prefixSum))
                    max = Math.Max(max, i - dic[prefixSum]);

                if (!dic.ContainsKey(prefixSum))
                    dic.Add(prefixSum, i);
            }

            return max;
        }

        //public static int FindMaxLength(int[] nums)
        //{
        //    int max = 0;
        //    int sum = 0;

        //    var map = new Dictionary<int, int>()
        //    {
        //        [0] = -1
        //    };

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        sum += (nums[i] == 0 ? -1 : 1);

        //        if (map.TryGetValue(sum, out int value))
        //            max = Math.Max(max, i - value);
        //        else
        //            map[sum] = i;
        //    }

        //    return max;
        //}
    }
}

