using System;

namespace GetOneFromTwoLists
{
    class ListNode
    {
        public int value;
        public ListNode next;
        public ListNode() { }

        public ListNode(int value, ListNode next)
        {
            this.value = value;
            this.next = next;
        }
    }
    static class MyClass
    {
        public static ListNode Add(this ListNode list, int value)
        {
            ListNode retList = list;
            ListNode temp = list;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = new ListNode { value = value, next = null };
            return retList;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode
            {
                value = 1,
                next = new ListNode
                {
                    value = 3,
                    next = new ListNode
                    {
                        value = 5,
                        next = null
                    }
                }
            };//1->3->5
            list1.Add(8);
            Console.WriteLine(list1.next.next.next.value);
        }
    }
}
