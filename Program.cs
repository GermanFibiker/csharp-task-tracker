
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new();

        while (true)
        {
            Console.WriteLine("\n=== Личный список задач ===");
            Console.WriteLine("1. Показать задачи");
            Console.WriteLine("2. Добавить задачу");
            Console.WriteLine("3. Отметить задачу выполненной");
            Console.WriteLine("4. Удалить задачу");
            Console.WriteLine("5. Выход");
            Console.Write("Выбор: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("Список пуст.");
                    }
                    else
                    {
                        for (int i = 0; i < tasks.Count; i++)
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                    }
                    break;

                case "2":
                    Console.Write("Введите задачу: ");
                    string? task = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(task))
                        tasks.Add(task);
                    break;

                case "3":
                    Console.Write("Номер выполненной задачи: ");
                    if (int.TryParse(Console.ReadLine(), out int doneIndex) &&
                        doneIndex > 0 &&
                        doneIndex <= tasks.Count)
                    {
                        tasks[doneIndex - 1] = "✓ " + tasks[doneIndex - 1];
                    }
                    break;

                case "4":
                    Console.Write("Номер задачи: ");
                    if (int.TryParse(Console.ReadLine(), out int index) &&
                        index > 0 &&
                        index <= tasks.Count)
                    {
                        tasks.RemoveAt(index - 1);
                    }
                    break;

                case "5":
                    return;
            }
        }
    }
}
