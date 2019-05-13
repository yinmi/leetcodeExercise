/*
 * @lc app=leetcode.cn id=28 lang=csharp
 *
 * [28] 实现strStr()
 */
public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle=="")
        {
            return 0;
        }
        char[] haystackArray=haystack.ToCharArray();
        char[] needleArray=needle.ToCharArray();
        int num=-1;
        /*
        找出第一个字符所在位置
         */
         for(int j=0;j<haystackArray.Length;j++)
        {
                if(haystackArray[j]==needleArray[0])
               {
                  num=j; 
                  break;
               } 
         }
         /*判断后续字符是否相同 */
             for(int k=1;k<needleArray.Length;k++)
            {
                if(num+k>=haystackArray.Length)
                {
                    num=-1;
                    break;
                }
                
                if(haystackArray[num+k]!=needleArray[k])
                {
                    num=-1;
                    break;
                }

             }
        return num;

    }
}

