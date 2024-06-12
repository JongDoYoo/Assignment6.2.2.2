namespace Assignment6._2._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            int[] newArray = { 1, 2, 3, 4 };
            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;

                foreach (int currentNum in array)
                {
                    if (array[i] != currentNum)
                    {
                        count *= currentNum;
                    }
                }
                newArray[i] = count;

            }
            Console.Write("[");
            foreach (int i in newArray)
            {
                Console.Write(i+",");
            }
            Console.Write("]");
        }
    }
}
