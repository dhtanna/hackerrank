using System;

namespace HackerRank.Solutions
{
    public class InsertNodeAtHead
    {

        // https://www.hackerrank.com/challenges/insert-a-node-at-the-head-of-a-linked-list/problem?isFullScreen=true

        // this soultion is working fine in local but it is giving error on platform while compiling.

        internal void TakeInput()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtHead(llist.head, llistItem);
                llist.head = llist_head;
            }

            PrintSinglyLinkedList(llist.head);
            Console.ReadKey();
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node)
        {
            Console.WriteLine("---------------Your output goes below--------------------");
            while (node != null)
            {
                Console.WriteLine(node.data);

                node = node.next;                
            }
        }

        SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
        {
            
            if (llist == null)
            {
                llist = new SinglyLinkedListNode(data);
            }
            else
            {
                SinglyLinkedListNode current = GetNewLList(llist);
                llist.data = data;
                llist.next = current;
                
            }

            return llist;

        }

        private SinglyLinkedListNode GetNewLList(SinglyLinkedListNode llist)
        {
            if (llist == null) 
            {
                return null;
            }

            var result = new SinglyLinkedListNode(llist.data);
            result.next = GetNewLList(llist.next);

            return result;
            
        }
    }

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

    }

    
}
