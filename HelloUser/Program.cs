using System;

namespace HelloUser
{
    class Program
    {
        static string Username;
        
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
            Username = Console.ReadLine();
            Console.WriteLine($"Привет, {Username}, сегодня {DateTime.Now:d}");
        }
    }
}