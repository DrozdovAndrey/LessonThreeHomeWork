// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
namespace HelloWorld

{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] cube = GetCube(n);
            for (int i = 0; i < cube.Length; i++)
            {
                Console.WriteLine(cube[i]);
            }


        }
        public static int[] GetCube (int a)
        {
            int[] aCube = new int[a];
            for (int i = 1; i <= aCube.Length; i++)
            {
                aCube[i-1] = i*i*i;
            }
            return aCube;
        }
    }
}