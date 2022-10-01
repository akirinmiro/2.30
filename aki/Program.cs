using System;
    namespace aki
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Полученное число: ");
            int n = int.Parse(Console.ReadLine());
            int a = n / 100;
            int c = (n / 10) % 10;
            int b = n % 10;
            int x = 100 * a + 10 * b + c;
            Console.WriteLine(x);
            Console.ReadLine();
        }
     
    }

}

