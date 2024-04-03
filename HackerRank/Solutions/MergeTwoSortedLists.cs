using System;

namespace HackerRank.Solutions
{
    public class MergeTwoSortedLists
    {
        // https://leetcode.com/problems/merge-two-sorted-lists/description/

        public void Execute()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));

            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            //ListNode list1 = new ListNode();
            //ListNode list2 = new ListNode(0);

            var list = MergeTwoLists(list1, list2);

            while (list.next != null)
            {
                Console.WriteLine($"{list.val},");
                list = list.next;
            }

        }

        public ListNode MergeTwoLists_old(ListNode list1, ListNode list2)
        {
            ListNode mergedList = new ListNode();

            if (list1 == null)
            {
                if (list2 == null)
                    return new ListNode();
            }
            else if (list1.next == null && list1.val <= 0)
            {
                if (list2 == null || (list2.next == null && list2.val <= 0))
                    return new ListNode();
            }
            else if (list2.next == null && list2.val <= 0)
            {
                if (list1 == null || (list1.next == null && list1.val <= 0))
                    return new ListNode();
            }

            if (list1 != null && list2 == null)
            {
                mergedList = new ListNode(list1.val);
            }
            else if (list1 == null && list2 != null)
            {
                mergedList = new ListNode(list2.val);
            }
            else if (list1 != null && list2 != null && list1.val < list2.val)
            {
                mergedList = new ListNode(list1.val);
                mergedList.next = MergeTwoLists_old(list1.next, list2);
            }
            else if (list2 != null)
            {
                mergedList = new ListNode(list2.val);
                mergedList.next = MergeTwoLists_old(list1, list2.next);
            }

            return mergedList;
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
