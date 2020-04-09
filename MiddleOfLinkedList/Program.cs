using System;
using System.Collections.Generic;

namespace MiddleOfLinkedList
{
    class Program
    {         

        static void Main(string[] args)
        {
            ListNode head = CreateList();

            var result = MiddleNode(head);            
        }

        static ListNode CreateList()
        {
            ListNode head = new ListNode(1);

            AddLast(head, 2);
            AddLast(head, 3);
            AddLast(head, 4);
            AddLast(head, 5);
            AddLast(head, 6);

            return head;            
        }

        static void AddLast(ListNode head, int x)
        {
            if (head == null)
            {
                head = new ListNode(x);
            }
            else
            {
                var cur = head;

                while (cur.next != null)
                {
                    cur = cur.next;
                }

                cur.next = new ListNode(x);
            }
        }

        public static ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
    }

    public class ListNode
    {
       public int val;
       public ListNode next;
       public ListNode(int x) 
       { 
            val = x;
       }
   }
}
