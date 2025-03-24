using System;
using System.Threading.Tasks;
using mukohorenko;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Оберіть, що ви хочете зробити:");
            Console.WriteLine("1 - Почати виконувати програму");
            Console.WriteLine("2 - Завершити програму");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();
            if (choice == "2") break;

            if (choice == "1")
            {
                int[] array = GetArrayFromUser();
                ChooseTask(array);
            }
            else
            {
                Console.WriteLine("Невірний вибір, спробуйте ще раз.");
            }
        }
    }

    static int[] GetArrayFromUser()
    {
        Console.Clear();
        Console.WriteLine("Оберіть спосіб введення масиву:");
        Console.WriteLine("1 - В один рядочок через пробіл");
        Console.WriteLine("2 - Ввести довжину, а потім заповнити числами");
        Console.WriteLine("3 - Ввести довжину і заповнити рандомом");
        Console.Write("Ваш вибір: ");

        string choice = Console.ReadLine();
        int[] array = new int[0];

        switch (choice)
        {
            case "1":
                Console.WriteLine("Введіть масив через пробіл:");
                string[] input = Console.ReadLine().Split();
                array = new int[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    array[i] = int.Parse(input[i]);
                }
                break;

            case "2":
                Console.Write("Введіть довжину масиву: ");
                int length = int.Parse(Console.ReadLine());
                array = new int[length];
                Console.WriteLine("Введіть числа:");
                for (int i = 0; i < length; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                break;

            case "3":
                Console.Write("Введіть довжину масиву: ");
                int size = int.Parse(Console.ReadLine());
                array = new int[size];
                Random rand = new Random();
                for (int i = 0; i < size; i++)
                {
                    array[i] = rand.Next(1, 101);
                }
                Console.WriteLine("Згенерований масив: " + string.Join(" ", array));
                break;

            default:
                Console.WriteLine("Невірний вибір!");
                return GetArrayFromUser();
        }
        return array;
    }

    static void ChooseTask(int[] array)
    {
        while (true)
        {
            Console.WriteLine("\nОберіть роботу для запуску:");
            Console.WriteLine("1 - Шульженко Софія");
            Console.WriteLine("2 - Мукогоренко Максим");
            Console.WriteLine("3 - Рибалка Владислав");
            Console.WriteLine("4 - Чуб Роман");
            Console.WriteLine("5 - Собко Владислав");
            Console.WriteLine("0 - Повернутися до головного меню");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    array = Task1.Run(array);
                    Console.WriteLine("Масив після змін: " + string.Join(" ", array));
                    break;
                case "2":
                    array = Task6.Run(array);
                    Console.WriteLine("Масив після змін: " + string.Join(" ", array));
                    break;
                case "3":
                    array = Task3.Run(array);
                    Console.WriteLine("Масив після змін: " + string.Join(" ", array));
                    break;
                case "4":
                    array = Task4.Run(array);
                    Console.WriteLine("Масив після змін: " + string.Join(" ", array));
                    break;
                case "5":
                    array = Task5.Run(array);
                    Console.WriteLine("Масив після змін: " + string.Join(" ", array));
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                    break;
            }
        }
    }
}
