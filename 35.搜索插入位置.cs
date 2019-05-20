/*
 * @lc app=leetcode.cn id=35 lang=csharp
 *
 * [35] 搜索插入位置
 */
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int num=-1;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==target)
            {
               return i;
            }
             if(nums[i]>target)
            {
                return i;
            }
           
        }
        return nums.Length;
    }
}

