﻿namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //A: Test Reveres Array method
            string[] names = { "Loai", "Ahmad", "Basel", "Khaled"};

            string[] reversedNames = ReverseArray(names);

            for (int i = 0; i < reversedNames.Length; i++)
            {
                Console.WriteLine(reversedNames[i]);
            }

            //B: Test Find Most Frequent Number method
            int[] numbers = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1, 2, 2, 2 ,2 };
              Console.WriteLine(FindMostFrequentNumber(numbers));
            

        }

        //A: Reveres Array method
        public static T[] ReverseArray<T>(T[] array)
        {
            int start =0;
            int end = array.Length -1;

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


        //B: Find Most Frequent Number method
        static int FindMostFrequentNumber(int[] numbers) {

            Dictionary<int, int> NumbersDictionary = new Dictionary<int, int>();

            foreach (int number in numbers) {

                if (NumbersDictionary.ContainsKey(number))
                    NumbersDictionary[number]++;
                else 
                    NumbersDictionary.Add(number, 1);
            }

            int MostFrequentNumber = numbers[0];
            int NumberOfOccurs = 0;

            foreach (var KeyValuePair in NumbersDictionary)
            {
                if (KeyValuePair.Value > NumberOfOccurs)
                {
                    NumberOfOccurs = KeyValuePair.Value;
                    MostFrequentNumber = KeyValuePair.Key;
                }
            }

            return MostFrequentNumber;
        }


    }
}
