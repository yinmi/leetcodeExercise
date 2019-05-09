/*
 * @lc app=leetcode.cn id=26 lang=csharp
 *
 * [26] 删除排序数组中的重复项
 */
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        /******
        循环整个数组剔除相同元素
        去除为空数组元素
        ******* */
        int Length=nums.Length;
        int record=0;
        for(int i=1;i<Length;)
        {
            if(nums[i-1]==nums[i])
            {
                 for(int j=i;j<Length-1;j++)
             {
                 nums[i]=nums[i+1];
             }
                Length--;
            }
            else
            {
                i++;
            }

        }
      return Length;
    }
}

