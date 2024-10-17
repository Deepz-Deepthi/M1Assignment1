namespace Q5
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("AA");
            list.AddLast("BB");
            list.AddLast("CC");
            list.AddLast("DD");

            Queue<string> queue = new Queue<string>(list);
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
