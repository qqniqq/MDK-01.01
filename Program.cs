using System;
using System.Collections.Generic;
using System.Linq;

public class Phone
{
    public string Model { get; set; } // Название модели
    public List<int> Sales { get; set; } // Список продаж по неделям
}

class Program
{
    // Словарь для хранения данных о телефонах по маркам
    static Dictionary<string, List<Phone>> PhonesByBrand = new Dictionary<string, List<Phone>>();

    // Функция для получения списка моделей по марке
    public static List<Phone> GetPhonesByBrand(string brand)
    {
        if (PhonesByBrand.ContainsKey(brand))
            return PhonesByBrand[brand];
        return null;
    }

    // Функция для расчета среднего числа продаж для каждой модели
    public static Dictionary<string, double> CalculateAverageSales(List<Phone> phones)
    {
        var averageSales = new Dictionary<string, double>();
        foreach (var phone in phones)
        {
            double average = phone.Sales.Average();
            averageSales.Add(phone.Model, average);
        }
        return averageSales;
    }

    // Функция для сортировки моделей по убыванию среднего числа продаж
    public static List<KeyValuePair<string, double>> SortPhonesBySales(Dictionary<string, double> averageSales)
    {
        return averageSales.OrderByDescending(x => x.Value).ToList();
    }

    static void Main(string[] args)
    {
        // Инициализация данных
        PhonesByBrand["Samsung"] = new List<Phone>
        {
            new Phone { Model = "A51", Sales = new List<int> { 5, 3, 7 } },
            new Phone { Model = "S21", Sales = new List<int> { 10, 8, 12 } }
        };

        PhonesByBrand["IPhone"] = new List<Phone>
        {
            new Phone { Model = "12 Pro", Sales = new List<int> { 15, 20, 18 } },
            new Phone { Model = "SE", Sales = new List<int> { 8, 6, 10 } }
        };

        // Ввод марки пользователем
        Console.WriteLine("Введите марку устройства (например, Samsung или IPhone):");
        string brand = Console.ReadLine();

        // Получение списка моделей по марке
        var phones = GetPhonesByBrand(brand);
        if (phones == null)
        {
            Console.WriteLine("Марка не найдена.");
            return;
        }

        // Расчет средних продаж
        var averageSales = CalculateAverageSales(phones);

        // Сортировка моделей по убыванию средних продаж
        var sortedPhones = SortPhonesBySales(averageSales);

        // Вывод результатов
        Console.WriteLine($"Модели марки {brand} (от самых продаваемых):");
        foreach (var phone in sortedPhones)
        {
            Console.WriteLine($"{phone.Key}: средние продажи = {phone.Value:F2}");
        }
    }
}
