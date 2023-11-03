using Datastruture;
namespace RemoveNthNodeFromEndOfList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode InputList = ListNode.CreateList(new int[] { 1, 2, 3, 4, 5 });
            ListNode ResultList = new Solution().RemoveNthFromEnd(InputList, 2);
            Console.WriteLine(ListNode.ToString(ResultList));
        }
    }

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int Length = 0;
            ListNode CurrentNode = head;
            while(CurrentNode is not null)
            {
                Length++;
                CurrentNode = CurrentNode.next;
            }
            int Index = Length - n;
            ListNode PrevRemovedNode = head;
            for(int i = 0; i < Index - 1; i++)
            {
               PrevRemovedNode = PrevRemovedNode.next;
            }
            if(Index == 0)
            {
                head = head.next;
            }
            else
            {
                PrevRemovedNode.next = PrevRemovedNode.next.next;
            }
            return head;
        }
    }
}