﻿using System;
using System.Collections.Generic;

namespace task2
{
    class CookingSteps
    {
        public static List<string> Cook()
        {
            List<string> steps = new List<string>();
            int i = 0;
            while (true)
            {
                Console.Clear();
                i++;
                Console.WriteLine("Введите " + i + " шаг приготовления или exit для выхода");
                string step = Console.ReadLine();
                if (step == "exit")
                {
                    break;
                }
                steps.Add(i + " " + step);
            }
            return steps;
        }
    }
}
