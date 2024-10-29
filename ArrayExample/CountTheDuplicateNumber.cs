namespace ArrayExample
{
    internal class CountTheDuplicateNumber
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 2, 4, 1, 5, 3, 6, 1 };
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != -1)
                {
                    count = 1;
                    for (int j = i + 1; j < array.Length; j++)
                    {

                        if (array[i] == array[j])
                        {
                            count++;
                            if (count > 1)
                            {
                                array[j] = -1;
                            }
                        }


                        

                    }
                    Console.WriteLine($"the number {array[i]} is repeated {count} times");

                }
            

            }
        }
    }
}
