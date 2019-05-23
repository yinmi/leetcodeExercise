/*
 * @lc app=leetcode.cn id=28 lang=csharp
 *KPM
 * [28] 实现strStr()
 */
public class Solution {
    public int StrStr(string haystack, string needle) {
        if(haystack==""&&needle=="")
        return 0;
        if(haystack==""&&needle!="")
        return -1;
         if(haystack!=""&&needle=="")
        return 0;
     char [] haystackArray=haystack.ToCharArray();
     char [] needleArray=needle.ToCharArray();
     int [] next=new int[needle.Length];
     nextSolution(next,needleArray);
     int i=0,j=0;
     for(;i<needleArray.Length&&j<haystack.Length;)
     {
         if(needleArray[i]==haystackArray[j])
         {
             i++;j++;
         }else if(next[i]>=0)
         {
             i=next[i];

         }else
         {
             i=0;j++;
         }
     }
     if(i>=needle.Length)
     {
         return j-needle.Length;
     }else
     {
         return -1;
     }

    }
    private void nextSolution(int [] next,char[] B)
    {
        next[0]=-1;
        for(int i=1;i<next.Length;i++)
        {
            int j=next[i-1];
            while((B[j+1]!=B[i]&&(j>=0)))
            {
                j=next[j];
            }
            if(B[j+1]==B[i])
            {
                next[i]=j+1;
            }else
            {
                next[i]=-1;
            }
        }
    }
}

