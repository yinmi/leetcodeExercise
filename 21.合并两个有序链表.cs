/*
 * @lc app=leetcode.cn id=21 lang=csharp
 *
 * [21] 合并两个有序链表
 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 /****
 使用归并排序
 定义一个新的结点L3
 L1中的结点数据与L2中的结点数据比较，把较小的数据存入L3的新结点并移动较小结点的指针
 重复上一步直到L1和L3的结点next都为NULL
 链表使用尾插法
 ****/
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode l3=new ListNode(0);
        l3.next=null;
        ListNode record=l3;
        while(l1!=null&&l2!=null)
        {
            /*归并 */
           if(l1.val<=l2.val)
           {
               record.next=l1;
               record=record.next;
               l1=l1.next;
           }
           if(l2.val<l1.val)
           {
               record.next=l2;
               record=record.next;
               l2=l2.next;
           }
        } 
          /*如果链表为空，则直接连接另一个链表 */
          if(l1==null)
          {
              record.next=l2;
          }
          if(l2==null)
          {
              record.next=l1;
          }
        return l3.next;
          
    }
}

