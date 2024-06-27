

namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 5, 2, 3, 4, 8, 9, 7, 9, 2 , 0, 0, 0};

            int[] sef = FindDuplicates(ints);

            for (int i = 0; i < sef.Length; i++) {

                Console.WriteLine(sef[i]);
            }


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
