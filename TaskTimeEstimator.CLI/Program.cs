using System;
using System.Collections.Generic;

namespace TaskTimeEstimator.CLI;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("⏱️  Оценка времени выполнения задач с учетом вероятности точности оценок");
        Console.WriteLine("--------------------------------------------------------");

        // Ввод базовых параметров
        double u = GetProbability();
        double globalFactor = GetGlobalFactor();
        
        var tasks = new List<Task>();
        while (true)
        {
            var task = CreateTask();
            if (task == null) break;
            tasks.Add(task);
        }

        if (tasks.Count == 0)
        {
            Console.WriteLine("🚫 Задачи не добавлены. Выход из программы.");
            return;
        }

        // Расчет оценок
        double totalBase = CalculateTotalBase(tasks);
        double probabilityAllAccurate = Math.Pow(u, tasks.Count);
        double finalEstimate = totalBase / probabilityAllAccurate * globalFactor;

        // Вывод результатов
        PrintResults(tasks, u, globalFactor, probabilityAllAccurate, totalBase, finalEstimate);
    }

    static double GetProbability()
    {
        Console.Write("\n🔮 Введите вероятность точности оценки одной задачи (0.1-0.99): ");
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double result) && result > 0.09 && result < 1.0)
                return result;
            
            Console.WriteLine("❌ Ошибка: введите число между 0.1 и 0.99 (например 0.8)");
        }
    }

    static double GetGlobalFactor()
    {
        Console.Write("\n🌍 Введите глобальный коэффициент фрактальности (1.0-2.5): ");
        return double.TryParse(Console.ReadLine(), out double result) 
            ? Math.Clamp(result, 1.0, 2.5) 
            : 1.5;
    }

    static Task CreateTask()
    {
        Console.Write("\n📝 Введите название задачи (ENTER для завершения): ");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name)) return null;

        Console.Write("⏳ Базовое время выполнения: ");
        double baseTime = double.Parse(Console.ReadLine());
        
        return new Task(name, baseTime);
    }

    static double CalculateTotalBase(List<Task> tasks)
    {
        double total = 0;
        foreach (var task in tasks) total += task.BaseTime;
        return total;
    }

    static void PrintResults(List<Task> tasks, double u, double globalFactor, 
                            double probabilityAllAccurate, double totalBase, double finalEstimate)
    {
        Console.WriteLine("\n\n✨ Результаты оценки:");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("| Задача   | Базовое время |");
        Console.WriteLine("-------------------------------------");
        
        foreach (var task in tasks)
        {
            Console.WriteLine($"| {task.Name,-8} | {task.BaseTime,13:F1} |");
        }
        
        Console.WriteLine("-------------------------------------");
        
        Console.WriteLine("\n📊 Расчет вероятности точности оценок:");
        Console.WriteLine($"Вероятность точности 1 задачи (u): {u:F2}");
        Console.WriteLine($"Количество задач (x): {tasks.Count}");
        Console.WriteLine($"Вероятность точности всех задач (u^x): {probabilityAllAccurate:F4}");
        
        Console.WriteLine("\n🧮 Итоговые показатели:");
        Console.WriteLine($"Суммарная базовая оценка: {totalBase:F1}");
        Console.WriteLine($"Глобальный коэффициент фрактальности: {globalFactor:F1}");
        Console.WriteLine($"\n🚀 ФИНАЛЬНАЯ ОЦЕНКА: {finalEstimate:F1}");
        Console.WriteLine($"📌 Формула: T = (Сумма времени) / (u^x) * F = {totalBase:F1} / {probabilityAllAccurate:F4} * {globalFactor:F1}");
    }
}

public class Task
{
    public string Name { get; }
    public double BaseTime { get; }

    public Task(string name, double baseTime)
    {
        Name = name;
        BaseTime = baseTime;
    }
}