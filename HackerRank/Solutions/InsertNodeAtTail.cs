using System;
using System.IO;

namespace HackerRank.Solutions
{
    public class InsertNodeAtTail
    {
        // https://www.hackerrank.com/challenges/insert-a-node-at-the-tail-of-a-linked-list/problem?isFullScreen=true&h_r=next-challenge&h_v=zen

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

            public SinglyLinkedList()
            {
                this.head = null;
            }

        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }

        internal void TakeInput()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
                llist.head = llist_head;
            }

            Console.ReadKey();
        }

        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            if (head == null)
            {
                head = new SinglyLinkedListNode(data);
            }
            else
            {
                var tailNode = new SinglyLinkedListNode(data);

                head = GetLastNode(head, tailNode);                
            }

            return head;
        }

        private static SinglyLinkedListNode GetLastNode(SinglyLinkedListNode head, SinglyLinkedListNode tailNode)
        {
            if (head.next == null)
            {
                head.next = tailNode;
            }
            else
            {
                head.next = GetLastNode(head.next, tailNode);
            }

            return head;
        }
    }
}
