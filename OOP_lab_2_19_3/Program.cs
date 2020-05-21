using System;

namespace OOP_lab_2_19_3
{
    class Program
    {
        public static int SumOddIndex(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int Sum(int[] array)
        {
            int sum = 0;
            int firstIndex = 0;
            int secondIndex = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] > 0)
                {
                    firstIndex = i;

                    break;
                }
            }

            for (int i = firstIndex + 1; i < array.Length; ++i)
            {
                if (array[i] > 0)
                {
                    secondIndex = i;

                    break;
                }
            }

            for (int i = firstIndex + 1; i < secondIndex; ++i)
            {
                sum += array[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[] array = new int[int.Parse(Console.ReadLine())];

            var random = new Random();

            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next(-100, 100);
            }

            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, array[i]);
            }

            Console.WriteLine("Cумa елементiв масиву з непарними номерами: {0}", SumOddIndex(array));
            Console.WriteLine("Сума елементiв масиву, розташованих мiж першим й другим додатними елементами: {0}", Sum(array));
        }
    }
}
