namespace Q4
{
    public class Program
    {
        static void Main(string[] args)
        {
           LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            int n = list.Count;
            n =  (n/ 2) + 1;
            int c = 0;

            for(LinkedListNode<int> node = list.First;node!=null;node=node.Next)
            {
                c++;
                if(c == n)
                {
                    Console.WriteLine("The middle element is: "+node.Value);
                }
            }
        }
    }
}
