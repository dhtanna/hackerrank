namespace HackerRank.Solutions
{
    public class SwapNodesInPair
    {
        // https://leetcode.com/problems/swap-nodes-in-pairs/

        public void Execute()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));

            var head = SwapNodes(list1);
        }

        public ListNode SwapNodes(ListNode head)
        {
            if (head == null)
                return null;
            if (head.next == null)
                return head;

            var next = head.next.next;

            var temp = head;

            head = head.next;

            head.next = temp;
            head.next.next = SwapNodes(next);

            return head;
        }
    }
}
