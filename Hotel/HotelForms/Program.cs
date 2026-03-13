using Hotel.Advisors;
using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelForms
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ГОСТИНИЦА: ПОМОЩНИК БРОНИРОВАНИЯ ===\n");

            var advisor = new HotelAdvisor();

            try
            {
                Console.Write("Введите дату заезда (дд.мм.гггг): ");
                string dateInput = Console.ReadLine();
                DateTime checkInDate = DateTime.ParseExact(dateInput, "dd.MM.yyyy", null);

                Console.WriteLine("\nДоступные категории номеров:");
                foreach (RoomCategory category in Enum.GetValues(typeof(RoomCategory)))
                {
                    Console.WriteLine($"  {(int)category + 1}. {category}");
                }

                Console.Write("\nВыберите категорию (введите номер): ");
                int categoryNumber = int.Parse(Console.ReadLine()) - 1;

                if (Enum.IsDefined(typeof(RoomCategory), categoryNumber))
                {
                    RoomCategory selectedCategory = (RoomCategory)categoryNumber;

                    Query userQuery = new Query(checkInDate, selectedCategory);

                    string advice = advisor.GetAdvice(userQuery);

                    Console.WriteLine($" Дата заезда: {checkInDate:dd.MM.yyyy}");
                    Console.WriteLine($"Категория: {selectedCategory}");
                    Console.WriteLine($" РЕКОМЕНДАЦИЯ:\n{advice}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Неверный номер категории!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}");
                Console.WriteLine("Пожалуйста, используйте формат даты: дд.мм.гггг (например, 24.02.2026)");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
        }
    }
}
