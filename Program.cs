namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Test Reveres Array method
            string[] names = { "Loai", "Ahmad", "Basel", "Khaled"};

            string[] reversedNames = ReverseArray(names);

            for (int i = 0; i < reversedNames.Length; i++)
            {
                Console.WriteLine(reversedNames[i]);
            }


        }

        // Reveres Array method
        static string[] ReverseArray(string[] array) { 
        
            string[] reversedArray = new string[array.Length];

            for (int i = 0; i < array.Length; i++) { 
            
                reversedArray[i] = array[array.Length -1 -i];

            }

            return reversedArray;

        }


    }
}
