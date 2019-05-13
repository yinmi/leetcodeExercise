/*
 * @lc app=leetcode.cn id=27 lang=csharp
 *
 * [27] 移除元素
 */
public class Solution {
    public int RemoveElement(int[] nums, int val) {
      int length=nums.Length;
        for (int i=0;i<length;)
        {
            if(nums[i]==val)
            {
                nums[i]=nums[length-1];
                length--;
            }
            else
            {
                i++;
            }
        }
        return length;      
    }
}

