using System;
using System.Collections;

namespace twosum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = { 3,2,4 };
            
            int target = 6;
            int[] final1 = TwoSumSample1(nums, target);
            int[] final2 = TwoSumSample2(nums, target);

        }

        public static int[] TwoSumSample1(int[] nums, int target)
        {
            int[] result = null;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = nums.Length - 1; i < j; j--)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result = new int[2]{ i,j};
                    }
                }
            }
            return result;

        }

        public static int[] TwoSumSample2(int[] nums, int target)
        {
            int[] result = null;
            Hashtable ht = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                ht.Add(i, nums[i]);
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (ht.ContainsValue(complement))
                {
                    for (int j = 0; j < i; j++)
                    {
                        if ((int)ht[j] == complement && i != j)
                        {
                            result = new int[2] { j, i };
                        }
                    }
                    
                }
                
            }

            return result;
        }


    }
    
}
