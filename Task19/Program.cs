// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
namespace HelloWorld

{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число:");
            string? number = Convert.ToString(Console.ReadLine());
            // int[] arrayNumber = new int[number.Length];
            // for (int i = 0; i < number.Length; i++)
            // {
            //     arrayNumber[i] = Convert.ToInt32(number[i].ToString());
            //     // Console.WriteLine(arrayNumber[i]);
            // }
            // Console.WriteLine(arrayNumber[^5]);
            // Console.WriteLine(number[3]);

            if (number[0] == number[^1])
            {
                if (number[01] == number[^2])
                {
                   Console.WriteLine("Это полиндром");
                }  
            }
            else
            {
                Console.WriteLine("Это не полиндром");
            }
            // int j = 1;
            // while (j < number.Length)
            // {
            //     if (arrayNumber[j-1] == number[^j])
            //     {
            //         j++;
            //     }
            //     else
            //     {
            //         break;
            //         Console.WriteLine();
            //     }
            // }

        }
    }
}