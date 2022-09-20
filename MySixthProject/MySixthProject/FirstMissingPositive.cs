using System;
namespace MySixthProject
{
    public class FirstMissingPositive
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(FirstMissingPositiveMethod(new int[] { 3, 3, 4, -1, 1 }));
        }

        public static int FirstMissingPositiveMethod(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 1;
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();
            // SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
            // apple

            // a -> 1
            // p -> 2
            // l -> 1
            // e -> 1

            // [3, 3, 4, -1, 1]

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] += 1;
                } else
                {
                    dict.Add(nums[i], 1);
                }
            }

            // key -> value
            // 3 -> 2
            // 4 -> 1
            // -1 -> 1
            // 1 -> 1

            //foreach(KeyValuePair<int, int> each in dict)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", each.Key, each.Value);
            //}

            for(int i = 1; i <= Int32.MaxValue; i++)
            {
                if (!dict.ContainsKey(i))
                {
                    return i;
                }
            }

            // 1 -> 320000000


            return -1;
        }
    }
}

