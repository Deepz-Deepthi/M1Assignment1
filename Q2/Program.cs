namespace Q2
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> nums = new LinkedList<int>();
            Console.WriteLine("Enter the total number of elements: ");
            int totalElements = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the values: ");
            for(int i=0; i < totalElements; i++)
            {
               int values = int.Parse(Console.ReadLine());
                nums.AddLast(values);
            }

            LinkedList<int> reversedList = new LinkedList<int>();
            foreach (int item in reversedList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            ////reversing manually
            //foreach (int item in nums)
            //{
            //    reversedList.AddFirst(item);
            //    Console.Write(item + " ");
            //}
        }
    }
}
