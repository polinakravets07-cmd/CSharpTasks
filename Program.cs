using System;
namespace GameMillionaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("Who Wants to Be a Millionaire?");
            Console.WriteLine("Current User Score: " + score);
            Console.WriteLine("Питання 1: Які кольори має прапор України?");
            Console.WriteLine("1. Жовтий і блакитний");
            Console.WriteLine("2. Червоний і зелений");
            Console.WriteLine("3. Чорний і жовтий");
            Console.WriteLine("4. Зелений і фіолетовий");
            Console.Write("Ваша відповідь: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                score += 100;
                Console.WriteLine("Правильна відповідь!");
            }
            else
            {
                Console.WriteLine("Неправильна відповідь!");
                return;
            }
            Console.WriteLine("Поточний рахунок: " + score);
            Console.WriteLine("Питання 2: Уякому місті знаходиться ДТЕУ?");
            Console.WriteLine("1. Вінниця");
            Console.WriteLine("2. Київ");
            Console.WriteLine("3. Львів");
            Console.WriteLine("4. Одеса");
            Console.Write("Ваша відповідь: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 2)
            {
                score += 100;
                Console.WriteLine("Правильна відповідь!");
            }
            else
            {
                Console.WriteLine("Неправильна відповідь!");
                return;
            }
            Console.WriteLine("Поточний рахунок: " + score);
            Console.WriteLine("Питання 3: Скільки буде 5 * 5?");
            Console.WriteLine("1. 10");
            Console.WriteLine("2. 20");
            Console.WriteLine("3. 25");
            Console.WriteLine("4. 30");
            Console.Write("Ваша відповідь: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 3)
            {
                score += 100;
                Console.WriteLine("Правильна відповідь!");
            }
            else
            {
                Console.WriteLine("Неправильна відповідь!");
                return;
            }
            Console.WriteLine("Поточний рахунок: " + score);
            Console.WriteLine("Питання 4: Яка планета є найближчою до Сонця?");
            Console.WriteLine("1. Земля");
            Console.WriteLine("2. Марс");
            Console.WriteLine("3. Венера");
            Console.WriteLine("4. Меркурій");
            Console.WriteLine("Ваша відповідь: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 4)
            {
                score += 100;
                Console.WriteLine("Правильна відповідь!");
            }
            else
            {
                Console.WriteLine("Неправильна відповідь!");
                return;
            }
            Console.WriteLine("Поточний рахунок: " + score);
            Console.WriteLine("Питання 5: Скільки континентів на Землі");
            Console.WriteLine("1. 5");
            Console.WriteLine("2. 6");
            Console.WriteLine("3. 7");
            Console.WriteLine("4. 8");
            Console.Write("Ваша відповідь: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 3)
            {
                score += 100;
                Console.WriteLine("Правильна відповідь!");
            }
            else
            {
                Console.WriteLine("Неправильна відповідь");
                return;
            }
            Console.WriteLine("Потосний рахунок: " + score);
            Console.WriteLine("Вітаємо! Ви відповіли на всі питання!");

            Console.ReadKey();
        }
    }
}