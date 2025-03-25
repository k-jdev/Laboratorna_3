using System;
namespace chub
{
    public class Task13_sigmaAlfa228
    {

        /*
        13. Якщо максимум серед елементів масиву є парним числом V, то замінити кожен з таких максимумів
            двома підряд однаковими числами V/2 (а якщо максимум непарний, то лишити масив незмінним)
        */
        public static int[] Run(int[] array)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            return СhangeMax(array);
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
