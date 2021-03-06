using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
            Console.WriteLine();
            task2();
            Console.WriteLine();
            task3();
            Console.WriteLine();
            Console.WriteLine();
            task4();
        }

        static void task1()
        {
            int sum = 0, otr = 0;
            int[] arr1 = new int[8] { -4, 7, 2, -5, -7, -1, 2, 7 };
            foreach (int i in arr1)
            {
                if (i > 0)
                    sum += i;
                else
                    otr += i;
            }
            Console.WriteLine($"sum = {sum} \notr = {otr}");
        }

        static void task2()
        {
            int j = 0;
            int[] arr2 = new int[8] { 2, 4, 6, 8, 10, 12, 14, 16 };
            int[] arr3 = new int[8];
            Console.WriteLine(arr2.Length);
            for (int i = (arr2.Length)-1; i >= 0; i--)
            {
                arr3[j] = arr2[i];
                j++;
            }
            for(int k = 0; k < arr3.Length; k++)
                Console.Write($"{arr3[k]} ");
        }

        static void task3()
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            int n = numbers.Length; // длина массива
            int k = n / 2;          // середина массива
            int temp;               // вспомогательный элемент для обмена значениями
            for (int i = 0; i < k; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[n - i - 1];
                numbers[n - i - 1] = temp;
            }
            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }
        }

        static void task4()
        {
            int[] arr4 = new int[7];
            //ввод чисел
            Console.WriteLine("Введите 7 элементов массива");
            for (int i = 0; i < arr4.Length; i++)
            {
                arr4[i] = Convert.ToInt16(Console.ReadLine());
            }

            //сортировка
            int temp;
            for(int i = 0; i < arr4.Length-1; i++)
            {
                for(int j = i+1; j < arr4.Length; j++)
                {
                    if(arr4[i] > arr4[j])
                    {
                        temp = arr4[i];
                        arr4[i] = arr4[j];
                        arr4[j] = temp;
                    }
                }
            }
            //вывод чисел
            for(int i = 0; i < arr4.Length; i++)
            {
                Console.Write($"{arr4[i]} ");
            }
        }
    }
}
