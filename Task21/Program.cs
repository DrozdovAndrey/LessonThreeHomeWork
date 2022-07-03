// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
namespace HelloWorld

{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите координату точки A по оси X:");
            double xa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки A по оси Y:");
            double ya = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки A по оси Z:");
            double za = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки B по оси X:");
            double xb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки B по оси Y:");
            double yb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки B по оси Z:");
            double zb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Расстояние между точками А и В равно: {Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya) + (zb-za)*(zb-za))}");

        }
    }
}