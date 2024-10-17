namespace Exception1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the x value: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the y value: ");
                int y = int.Parse(Console.ReadLine()) ;
                int z = x / y;
                Console.WriteLine(z);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
