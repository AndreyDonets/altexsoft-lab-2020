using System;
using System.Collections.Generic;

namespace task2
{
    class CookingSteps
    {
        public static List<string> Cook()
        {
            List<string> steps = new List<string>();
            int i = 1;
            Console.WriteLine("Введите " + i + " шаг приготовления.");
            while (true)
            {

                string step = Console.ReadLine();
                Console.Clear();
                if (string.IsNullOrWhiteSpace(step))
                {
                    Console.Write("Введите " + i + " шаг приготовления.");
                    if (steps.Count > 0)
                        Console.Write(" next - перейти к следующему пункту");
                    Console.WriteLine();
                    continue;
                }
                if (steps.Count == 0 && step == "next")
                {
                    Console.WriteLine("Должен быть как минимум 1 шаг приготовления для настоящего рецепта");
                    continue;
                }
                else if (steps.Count > 0 && step == "next")
                    break;
                steps.Add(i + " " + step);
                i++;
                Console.WriteLine("Введите " + i + " шаг приготовления. next - перейти к следующему пункту");
            }
            Console.Clear();
            return steps;
        }
    }
}
