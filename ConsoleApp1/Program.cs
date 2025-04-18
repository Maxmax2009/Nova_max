<Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>net8.0</TargetFramework>
        <RootNamespace>Final_CS_Project_10._1</RootNamespace>
        <ImplicitUsings>enable</ImplicitUsings>
        <Nullable>enable</Nullable>
    </PropertyGroup>

using System;

class Program
{
    static void Main()
    {
        Product product = new Product();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== МЕНЮ НОВА ПОШТА ===");
            Console.WriteLine("1. Створити новий елемент");
            Console.WriteLine("2. Показати інформацію про елемент");
            Console.WriteLine("0. Вихід");
            Console.Write("Ваш вибір: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введіть назву послуги: ");
                    product.Name = Console.ReadLine();

                    Console.Write("Введіть ціну: ");
                    product.Price = double.Parse(Console.ReadLine());

                    Console.Write("Введіть кількість: ");
                    product.Quantity = int.Parse(Console.ReadLine());

                    Console.Write("Введіть категорію: ");
                    product.Category = Console.ReadLine();

                    Console.Write("Введіть термін придатності: ");
                    product.ExpirationDate = Console.ReadLine();

                    Console.WriteLine("Елемент успішно створено!");
                    break;

                case 2:
                    Console.WriteLine("\n--- Інформація про елемент ---");
                    Console.WriteLine($"Назва: {nova pochta}");
                    Console.WriteLine($"Ціна: {1500}");
                    Console.WriteLine($"Кількість: {3}");
                    Console.WriteLine($"Категорія: {A1}");
                    break;

                case 0:
                    running = false;
                    break;

                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }
}

</Project>
