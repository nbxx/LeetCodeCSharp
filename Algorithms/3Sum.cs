// Source : https://leetcode.com/problems/3sum/ 
// Author : codeyu 
// Date : 10/6/16 

/***************************************************************************************
*
* Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? 
* Find all unique triplets in the array which gives the sum of zero.
* Note:
*  The resution set must not contain duplicate triplets.
* For example, given array S = [-1, 0, 1, 2, -1, -4],
* 
* A resution set is:
* [
*   [-1, 0, 1],
*   [-1, -1, 2]
* ]
* 
*
**********************************************************************************/

using Algorithms.Utils;
using System.Collections.Generic;
namespace Algorithms
{
    public class Solution015 
    {
        public static IList<IList<int>> ThreeSum(int[] nums) 
        {
            return ThreeSum(nums, 0);
        }
        private static IList<IList<int>> ThreeSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if(nums.Length < 3) return result;
            Helper.Sort(nums);
            for(var i=0; i<nums.Length-2; i++)
            {
                if(i > 0 && nums[i] == nums[i-1]) { continue; } //去重
                int left = i + 1, right=nums.Length - 1;
                while(left < right)
                {
                    int curSum = nums[left] + nums[right];
                    int curTarget = target - nums[i];
                    if(curSum == curTarget)
                    {
                        IList<int> res = new List<int>();
                        res.Add(nums[i]);
                        res.Add(nums[left]);
                        res.Add(nums[right]);
                        result.Add(res);
                        left++;
                        right--;
                        while(nums[left]==nums[left-1]) { left++; }
                        while(nums[right]==nums[right+1]) { right--; }
                    }
                    else if(curSum < curTarget)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }     
                }
            }
            return result;
        }
    }
}

