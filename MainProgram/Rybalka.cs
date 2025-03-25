using System;
namespace Rybalka
{
    class Task14
    {
        public static void Main()
        {

            InsertAbsAfterNegatives(ref arr);
        }

        private static int[] InsertAbsAfterNegatives(ref int[] array)
        {
            int countNegatives = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    countNegatives++;
            }

            if (countNegatives == 0)
                return false;

            int newLength = array.Length + countNegatives;
            int[] newArray = new int[newLength];

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                newArray[j] = array[i];
                j++;
                if (array[i] < 0)
                {
                    newArray[j] = Math.Abs(array[i]);
                    j++;
                }
            }

            array = newArray;
            return array;
        }
    }
}
