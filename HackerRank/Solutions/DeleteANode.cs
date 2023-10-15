using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Solutions
{
    public class DeleteANode
    {

        // https://www.hackerrank.com/challenges/delete-a-node-from-a-linked-list/problem?isFullScreen=true

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

        static void PrintSinglyLinkedList(SinglyLinkedListNode node)
        {
            while (node != null)
            {
                Console.WriteLine(node.data);

                node = node.next;
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

            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist1 = deleteNode(llist.head, position);
            PrintSinglyLinkedList(llist1);
        }

        static SinglyLinkedListNode deleteNode(SinglyLinkedListNode llist, int position)
        {
            int i = 0;

            SinglyLinkedList result = new SinglyLinkedList();

            while (llist != null)
            {
                if (position != i)
                {
                    result.InsertNode(llist.data);
                }
                llist = llist.next;
                i++;
            }           

            return result.head;

        }
    }
}
