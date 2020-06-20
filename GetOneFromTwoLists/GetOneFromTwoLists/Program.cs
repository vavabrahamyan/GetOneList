using System;
using System.Threading;

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
        public static void PrintList(this ListNode list)
        {
            ListNode temp = list;
            string str = "";
            while(temp.next != null)
            {
                str += temp.value.ToString();
                temp = temp.next;
                str += " -> ";
            }
            str += temp.value.ToString();
            Console.WriteLine(str);
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
            ListNode list2 = new ListNode
            {
                value = 2,
                next = new ListNode
                {
                    value = 4,
                    next = new ListNode
                    {
                        value = 6,
                        next = null
                    }
                }
            };//2->4->6


            ListNode newList = GetOne(list1, list2);
            newList.PrintList();
        }
        static ListNode GetOne(ListNode list1, ListNode list2)
        {
            ListNode retList;
            ListNode temp1;
            ListNode temp2;

            if (list1.value <= list2.value)
            {
                retList = new ListNode { value = list1.value, next = null };
                temp1 = list1.next;
                temp2 = list2;
            }
            else
            {
                retList = new ListNode { value = list2.value, next = null };
                temp1 = list2.next;
                temp2 = list1;
            }
            while(temp1!=null || temp2 != null)
            {
                if(temp1!= null && temp2 != null)
                {
                    if(temp1.value <= temp2.value)
                    {
                        retList.Add(temp1.value);
                        temp1 = temp1.next;
                    }
                    else
                    {
                        retList.Add(temp2.value);
                        temp2 = temp2.next;
                    }
                }
                else if(temp1!= null)
                {
                    retList.Add(temp1.value);
                    temp1 = temp1.next;
                }
                else
                {
                    retList.Add(temp2.value);
                    temp2 = temp2.next;
                }
            }
            return retList;
        }
    }
}
