// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// namespace HelloWorld

// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("Введите пятизначное число:");
//             string? number = Convert.ToString(Console.ReadLine());
           
            

//             if (number[0] == number[^1])
//             {
//                 if (number[01] == number[^2])
//                 {
//                    Console.WriteLine("Это полиндром");
//                 }  
//             }
//             else
//             {
//                 Console.WriteLine("Это не полиндром");
//             }
           

//         }
//     }
// }

namespace HelloWorld

{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число:");
            string? number = Convert.ToString(Console.ReadLine());   
            for (int i = 1; i <= number.Length / 2; i++)
            {
                
                
                if (number[i-1] == number[^i])
                {
                    if(i == number.Length/2)
                    {
                        Console.WriteLine("Это полиндром");
                    }
                    
                    
                }
                else 
                {
                    Console.WriteLine("Это не полиндром");
                    break;
                }
            }
            

        }
    }
}

//  int[] arrayNumber = new int[number.Length]; не убираю чтобы сохранить!!!
//             for (int i = 0; i < number.Length; i++)
//             {
//                 arrayNumber[i] = Convert.ToInt32(number[i].ToString());
//                 // Console.WriteLine(arrayNumber[i]);
//             }