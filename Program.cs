using System;

namespace vn_mode_csharp_dz25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[10];
            int minNumberForRandom = 0;
            int maxNumberForRandom = 9;
            int tempNumber;
            Random randomNumber = new Random();

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = randomNumber.Next(minNumberForRandom, maxNumberForRandom);
            }
            Console.Write("Исходный массив чисел: ");

            foreach (int number in arrayNumbers)
            {
                Console.Write(number + " ");
            }

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                for (int j = 0; j < arrayNumbers.Length; j++)
                {
                    if (arrayNumbers[i] < arrayNumbers[j])
                    {
                        tempNumber = arrayNumbers[i];
                        arrayNumbers[i] = arrayNumbers[j];
                        arrayNumbers[j] = tempNumber;
                    }
                }
            }
            Console.Write("\nИзменённый массив чисел: ");

            foreach (int number in arrayNumbers)
            {
                Console.Write(number + " ");
            }

        }
    }
}
