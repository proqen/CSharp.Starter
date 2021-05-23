using System;

namespace Task9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]
            {
                16,
                5,
                2,
                7,
                3,
                15,
                0
            };
            Console.WriteLine("первое задание");
            Console.WriteLine("Массив до реверса :");
            PrintArray(array);
            Console.WriteLine("Массив после реверса :");
            MyReverse(array);
            Console.WriteLine("Второе задание");
            SubArray( array, 4, 7);
            
        }


        public static void MyReverse( int[] array)
        {
            int i = 0;
            int j = array.Length - 1;
            for (; i < j; ++i, --j)
            {
                int tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
            PrintArray( array);
        }

        public static void PrintArray( int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}) {array[i]}");
            }
        }

        public static int[] SubArray( int[] array, int index, int count)
        {
            int i = index;
            if (count < array.Length)
            {
                for (i = index; i <= array.Length - 1; i++)
                    Console.WriteLine(array[i]);
            }
            if (count >= array.Length)
            {
                int[] arrayWithOnes = new int[count + 1];
                Array.Copy(array, arrayWithOnes, array.Length);
                for (i = index; i <= arrayWithOnes.Length - 1; i++)
                {
                    if (arrayWithOnes[i] == 0)
                    {
                        arrayWithOnes[i] = 1;
                    }
                    Console.WriteLine(arrayWithOnes[i]);
                }
            }
            return array;
        }
    }
}
