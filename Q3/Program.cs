namespace Q3
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            LinkedList<int> l1 = new LinkedList<int>();
            list.AddLast(10);
            l1.AddLast(20);
            list.AddLast(30);
            l1.AddLast(40);
            list.AddLast(50);
            l1.AddLast(60);
            list.AddLast(70);
            l1.AddLast(80);

            LinkedList<int> finalList = new LinkedList<int>();
            foreach(int i in list)
            {
                finalList.AddFirst(i);
            }
            foreach (int i in l1)
            {
                finalList.AddFirst(i);
            }
            foreach(int i in finalList.Order())
            {
                Console.WriteLine(i);
            }
        }
    }
}
