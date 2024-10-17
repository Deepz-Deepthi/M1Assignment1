namespace Exception2
{
    public class Program
    {
        static void Main(string[] args)
        {
           string s = null;
            try
            {
                int res = s.Length;
                Console.WriteLine(res);
            }
            catch(NullReferenceException ex) 
            {
                Console.WriteLine("A NullReferenceException occurred");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
