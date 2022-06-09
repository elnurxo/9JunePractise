using System;
using System.Collections.Generic;
using System.Text;

namespace _9JunePractise.Extensions
{
    static class ExtensionMethods
    {
        public static string ReverseWord(this string word)
        {
            string reversedword = "";

            for (int i = word.Length-1; i >= 0; i--)
            {
                reversedword += word[i];
            }

            return reversedword;
        }

       public static int[] AddElement(this int[] nums,int num)
        {
            Array.Resize(ref nums, nums.Length + 1);
            nums[nums.Length - 1] = num;

            return nums;
        }
    }
}
