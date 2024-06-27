

namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] test1 = { 1, 2, 3, 1, 2, 3 };
            Console.WriteLine($"Input: [{string.Join(",", test1)}]");
            Console.WriteLine($"Output: [{string.Join(",", FindDuplicates(test1))}]");

            Console.WriteLine("======================================================");

            int[] test2 = { 16, 8, 31, 17, 15, 23, 17, 8 };
            Console.WriteLine($"Input: [{string.Join(",", test2)}]");
            Console.WriteLine($"Output: [{string.Join(",", FindDuplicates(test2))}]"); 
            
            Console.WriteLine("======================================================");

            int[] test3 = { 5, 10, 16, 20, 10, 16 };
            Console.WriteLine($"Input: [{string.Join(",", test3)}]");
            Console.WriteLine($"Output: [{string.Join(",", FindDuplicates(test3))}]");

            Console.ReadKey();

        }

        public static int[] FindDuplicates(int[] nums)
        {
            Dictionary<int, int> directory = new Dictionary<int, int>();

            foreach (int num in nums)
                if (directory.ContainsKey(num))
                    directory[num]++;
                else
                    directory.Add(num, 1);

            List<int> duplicates = new List<int>();

            foreach (var kvp in directory)
                if (kvp.Value > 1)
                    duplicates.Add(kvp.Key);

            return duplicates.ToArray();
        }


    }
}
