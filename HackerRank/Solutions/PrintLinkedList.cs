using System;

namespace HackerRank.Solutions
{
    public class PrintLinkedList
    {
        // https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list/problem?isFullScreen=true

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

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        internal void TakeInput()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            printLinkedList(llist.head);
        }

        private void printLinkedList(SinglyLinkedListNode head)
        {
            if(head == null)
            {
                return;
            }
            var currentNode = head;

            do
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;

            } while (currentNode != null);

        }
    }
}
