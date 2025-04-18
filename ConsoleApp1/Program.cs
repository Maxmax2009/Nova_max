using System;

namespace NovaPoshtaApp
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string ExpirationDate { get; set; }
    }

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
                        // Автоматичне заповнення вашими даними
                        product.Name = "Нова Пошта";
                        product.Price = 1500;
                        product.Quantity = 3;
                        product.Category = "A1";
                        product.ExpirationDate = "12.12.2025";

                        Console.WriteLine("Елемент успішно створено!");
                        break;

                    case 2:
                        Console.WriteLine("\n--- Інформація про елемент ---");
                        Console.WriteLine($"Назва: {Poshta}");
                        Console.WriteLine($"Ціна: {1500}");
                        Console.WriteLine($"Кількість: {3}");
                        Console.WriteLine($"Категорія: {A1}");
                        Console.WriteLine($"Термін придатності: {3 days}");
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
}
