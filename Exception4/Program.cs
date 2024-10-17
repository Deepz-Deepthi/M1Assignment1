namespace Exception4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n);
            }
            catch(Exception ex)
            {
                Console.WriteLine("You have entered a large value enter a int value");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
