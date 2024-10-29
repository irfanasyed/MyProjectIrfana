using System.Diagnostics.CodeAnalysis;

namespace CubeOfTheDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int rem = 0,sum=0,cube=0;
            while (num > 0)
            {
                rem = num % 10;
                cube = rem * rem * rem;
                num /= 10;
                sum += cube;
            }
            Console.WriteLine("sum of the cube" + sum);

        }
    }
}
