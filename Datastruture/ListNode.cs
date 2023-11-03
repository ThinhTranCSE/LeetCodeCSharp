namespace Datastruture
{
    public class ListNode
    {
        public int val { get; set; }
        public ListNode? next { get; set; }

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
        static public ListNode? CreateList(int[] values)
        {

            ListNode? Head = null;
            ListNode? CurrentNode = null;
            foreach (int value in values)
            {
                ListNode? NewNode = new ListNode(value);
                if (CurrentNode is null)
                {
                    CurrentNode = NewNode;
                }
                else
                {
                    CurrentNode.next = NewNode;
                    CurrentNode = CurrentNode.next;
                }
                Head ??= CurrentNode;
            }
            return Head;
        }

        public static String ToString(ListNode? list)
        {
            string result = "";
            while (list is not null)
            {
                result += list.val + ",";
                list = list.next;
            }
            return "[" + result + "]";
        }
    }
}