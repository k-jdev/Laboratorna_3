using System;
namespace Lab3_DinamicArray
{
    internal class Program
    {

        /*
        13. Якщо максимум серед елементів масиву є парним числом V, то замінити кожен з таких максимумів
            двома підряд однаковими числами V/2 (а якщо максимум непарний, то лишити масив незмінним)
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] array = GetArrayFromUser();
            Console.WriteLine("Заданий масив:");
            PrintArray(array);

            array = СhangeMax(array);
            if (array == null) return;

            Console.WriteLine("Масив після змін:");
            PrintArray(array);
        }
        static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        static int[] GetArrayFromUser()
        {
            Console.WriteLine("Ви бажаєте заповнити масив випадковим чином чи вручну?");
            Console.WriteLine("1 - Випадковим чином");
            Console.WriteLine("2 - Вручну");
            int choice = GetUserChoice();

            if (choice == 1)
            {
                return GetRandomArray();
            }

            Console.WriteLine("Ви бажаєте вводити елементи в окремих рядках чи одним рядком?");
            Console.WriteLine("1 - Окремими рядками");
            Console.WriteLine("2 - Одним рядком");
            int inputMethod = GetUserChoice();

            if (inputMethod == 1)
                return GetArrayFromUserByLines();
            else
                return GetArrayFromUserBySingleLine();

        }

        static int[] GetRandomArray()
        {
            int size = Input("Введiть кiлькiсть елементiв масиву:");

            int minValue = Input("Введiть мiнiмальне значення випадкових чисел:");

            int maxValue = Input("Введiть максимальне значення випадкових чисел:");

            if (minValue > maxValue)
            {
                Console.WriteLine("Мiнiмальне значення не може бути бiльшим за максимальне. Повторiть введення.");
                return GetRandomArray();
            }

            Random rand = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(minValue, maxValue + 1);
            }

            return array;
        }


        static int[] GetArrayFromUserByLines()
        {
            int size = Input("Введiть кiлькiсть елементiв масиву:");

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Елемент [{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        static int[] GetArrayFromUserBySingleLine()
        {
            Console.WriteLine("Введiть елементи масиву через пробiл:");
            string[] parts = Console.ReadLine().Trim().Split(' ');

            int[] array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = int.Parse(parts[i]);
            }

            return array;
        }
        static int GetUserChoice()
        {
            while (true)
            {
                int input = Input("Введiть 1 або 2:");
                if (input == 1 || input == 2)
                {
                    return input;
                }
                Console.WriteLine("Помилка: введiть тiльки 1 або 2.");
            }

        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static int[] СhangeMax(int[] array)
        {
            int max = FindMax(array);
            if (max % 2 != 0)
            {
                Console.WriteLine("Максимальне число непарне!");
                return null;
            }

            int add = 0;
            for (int i = 0; i < array.Length;i++)
            {
                if(array[i] == max)
                {
                    add++;
                }
            }

            int[] newArray = new int[array.Length + add];
            int j = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    newArray[j++] = max / 2;
                    newArray[j++] = max / 2;
                }
                else
                {
                    newArray[j++] = array[i];
                }
            }
            return newArray;
        }
        static int FindMax(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }


    }
}
