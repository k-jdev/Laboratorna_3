using System;
using System.Runtime.CompilerServices;
//13. Додати рядок перед рядком, що містить мінімальний елемент (якщо у різних місцях є кілька елементів
//з однаковим мінімальним значенням, то брати перший з них)

namespace block_2_task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину зовнішнього масиву (к-ть підмасивів): ");
            int n = int.Parse(Console.ReadLine());

            int[][] j_arr = new int[n][];

            for(int i =0; i < n;i++)
            {
                Console.WriteLine($"Введіть {i} рядочок масиву (через пробіл): ");
                string[] input = Console.ReadLine().Split();
                j_arr[i] = new int[input.Length];

                for (int j = 0; j < input.Length; j++)
                {
                    j_arr[i][j] = int.Parse(input[j]);
                }
            }



            Console.WriteLine();
            Console.WriteLine("Отже ваш остаточний масив буде виглядати так: ");
            ArrOutput(FindFirstSmalNumAndAddZeroRow(j_arr));


        }

        private static void ArrOutput(int[][] j_arr)
        {
            for(int i =0; i < j_arr.Length; i++)
            {
                for(int j = 0; j < j_arr[i].Length; j++)
                {
                    Console.Write(j_arr[i][j] + "  ");
                }
                Console.WriteLine();
            }
        }

        private static int[][] FindFirstSmalNumAndAddZeroRow(int[][] j_arr)
        {
            int minNum = j_arr[0][0];
            int minArrIndexRow = 0;

            for(int i = 0; i < j_arr.Length; i++)
            {
                for (int j = 0;j < j_arr[i].Length;j++)
                {
                    if(minNum > j_arr[i][j])
                    {
                        minNum = j_arr[i][j];
                        minArrIndexRow = i;
                    }
                }
            }

            int[] zeroStr = new int[5];
            Array.Resize(ref j_arr, j_arr.Length + 1);

            for (int i = j_arr.Length - 1; i > minArrIndexRow; i--)
            {
                j_arr[i] = j_arr[i - 1];
            }

            j_arr[minArrIndexRow] = zeroStr; 

            return j_arr;
        }
    }
}
