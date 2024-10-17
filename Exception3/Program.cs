namespace Exception3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] alphabets = { "A", "B", "C", "D", "E" };
            Console.WriteLine("Enter the index which you want to access");

            try
            {
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine($"Alphabets at index {index}: {alphabets[index]}");
            }
            catch( Exception ex )
            {
                Console.WriteLine("Index is out of range");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
