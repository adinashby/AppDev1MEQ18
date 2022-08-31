//using System;
//namespace MyThirdProject
//{
//    public class Lab2Q2
//    { 
//            public static void nextPermutation(int[] nums)
//            {
//                int i = nums.Length - 2;

//                while (i >= 0 && nums[i + 1] <= nums[i])
//                {
//                    i--;
//                }

//                if (i >= 0)
//                {
//                    int j = nums.Length - 1;

//                    while (nums[j] <= nums[i])
//                    {
//                        j--;
//                    }
//                    swap(nums, i, j);
//                }

//                reverse(nums, i + 1);
//            }

//            private static void reverse(int[] nums, int start)
//            {
//                int i = start, j = nums.Length - 1;

//                while (i < j)
//                {
//                    swap(nums, i, j);
//                    i++;
//                    j--;
//                }
//            }

//        private static void swap(int[] nums, int i, int j)
//        {
//            int temp = nums[i];
//            nums[i] = nums[j];
//            nums[j] = temp;
//        }

//        public static void Main(String[] args)
//        {
//            int[] nums = { 1, 1, 5 };

//            nextPermutation(nums);

//            foreach(int each in nums)
//            {
//                Console.WriteLine(each);
//            }
//        }
//    }
//}

