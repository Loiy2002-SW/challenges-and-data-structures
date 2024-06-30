

namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array1Test1 = { 1, 2, 3, 0 };
            int[] array2Test1 = { 2, 3, 4, 9 };


            Console.WriteLine($"Input: [{string.Join(",", array1Test1)}], [{string.Join(",", array2Test1)}]");
            Console.WriteLine($"Output: [{string.Join(",", CommonElements(array1Test1, array2Test1))}]");

            Console.WriteLine("======================================================");

            int[] array1Test2 = { 79, 8, 15 };
            int[] array2Test2 = { 23, 79, 8 };


            Console.WriteLine($"Input: [{string.Join(",", array1Test2)}], [{string.Join(",", array2Test2)}]");
            Console.WriteLine($"Output: [{string.Join(",", CommonElements(array1Test1, array2Test1))}]");

            Console.WriteLine("======================================================");

            int[] array1Test3 = { 5, 10, 15, 20 };
            int[] array2Test3 = { 10, 15, 25 };

            Console.WriteLine($"Input: [{string.Join(",", array1Test3)}], [{string.Join(",", array2Test3)}]");
            Console.WriteLine($"Output: [{string.Join(",", CommonElements(array1Test1, array2Test1))}]");

            Console.WriteLine("======================================================");

            Console.ReadKey();

        }

        public static int[] CommonElements(int[] array1, int[] array2)
        {
            Dictionary<int, int> directory = new Dictionary<int, int>();

            for (int i = 0; i < array1.Length; i++)
            {
                if (!directory.ContainsKey(array1[i]))
                {
                    directory.Add(array1[i], 1);
                }

            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (directory.ContainsKey(array2[i]))
                {
                    directory[array2[i]] = 2;
                }

            }

           
            List<int> commons = new List<int>();

            foreach (var kvp in directory)
                if (kvp.Value == 2)
                    commons.Add(kvp.Key);

            return commons.ToArray();
        }


    }
}
