namespace Q6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Tuple<int>, string > di = new Dictionary<Tuple<int>, string>();
            Tuple<int> t1 = new Tuple<int>(1);
            Tuple<int> t2 = new Tuple<int>(2);

            di.Add(t1, "Hello");
            di.Add(t2,"Hey");
            foreach(var item in di)
            {
                Console.WriteLine(item);
            }
        }
    }
}
