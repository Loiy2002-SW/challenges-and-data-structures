using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;

namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Challenge 1 A: Test Reveres Array method
            string[] names = { "Loai", "Ahmad", "Basel", "Khaled" };

            string[] reversedNames = ReverseArray(names);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Reversed array of name: [{string.Join(", ", reversedNames)}]");
            Console.WriteLine();

            //Challenge 1 B: Test Find Most Frequent Number method
            int[] numbers1 = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1, 2, 2, 2, 2 };

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Most frequent number is: {FindMostFrequentNumber(numbers1)}");
            Console.WriteLine();

            //Challenge 2: Test Miximum value method
            int[] numbers2 = { -5, 0, 0, 5, 6, 90, -100, 88 };

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Maximum value is: {MaximumValue(numbers2)}");
            Console.WriteLine();

            //Challenge 3: Test Remove Middle Value from Array
            int[] OddLength = { -5, -100, 70, 0, -100, 50, 6, 8, 34 };
            int[] EvenLength = { 5, 10, 40, 66, 9, 3, 0, -16 };

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"OddLength after removal: [{string.Join(", ", RemoveMiddleValueFromArray(OddLength))}] ");
            Console.WriteLine($"EvenLength after removal: [{string.Join(", ", RemoveMiddleValueFromArray(EvenLength))}] ");
            Console.WriteLine();

            //Challenge 4: Test Middle Value
            int[] numbers3 = { 70, 0, -10, 5, 6, 7, 1 };
            int number = 8;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Array after insert {number}: [{string.Join(", ", MiddleValue(numbers3, number))}] ");
            Console.WriteLine();


            Console.ResetColor();
            Console.ReadKey();

        }

        //Challenge 1 A: Reveres Array method
        public static T[] ReverseArray<T>(T[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            while
             (start < end)
            {
                T temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
            return array;
        }


        //Challenge 1 B: Find Most Frequent Number method
        public static int? FindMostFrequentNumber(int[] array)
        {
            if (array.Length == 0)
                return null;

            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int num in array)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }
            return counts.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }

        //Challenge 2: Maximum value
        public static int? MaximumValue(int[] numbers)
        {
            if (numbers.Length == 0)
                return null;

            int maxNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                    maxNumber = numbers[i];
            }
            return maxNumber;
        }

        //Challenge 3: Remove Middle Value from Array

        public static int[] RemoveMiddleValueFromArray(int[] numbers)
        {
            if (numbers.Length == 0)
                return numbers;

            int midIndex = numbers.Length / 2;
            int newSize = numbers.Length % 2 == 0 ? numbers.Length - 2 : numbers.Length - 1;
            int[] result = new int[newSize];

            for (int i = 0, j = 0; i < numbers.Length; i++)
            {
                // Skip the middle elements
                if ((numbers.Length % 2 == 0 && (i == midIndex || i == midIndex - 1)) || (numbers.Length % 2 != 0 && i == midIndex))
                    continue;


                result[j++] = numbers[i];
            }

            return result;
        }

        //Middle Value 

        public static int[] MiddleValue(int[] array, int number)
        {
            int middleIndex = 0;

            if (array.Length %2 == 0)
                middleIndex = array.Length / 2;
            else
                middleIndex = array.Length / 2 +1;

            int[] result = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i < middleIndex)
                    result[i] = array[i];
                else if (i == middleIndex)
                    result[i] = number;
                else
                    result[i + 1] = array[i];
            }
            return result;
        }
    }
}
