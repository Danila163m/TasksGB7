int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.");
    Console.WriteLine("2. Задача 2. Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
    Console.WriteLine("3. Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
        Console.WriteLine("введите количество строк");
        int linesVol = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите количество столбцов");
        int columnsVol = Convert.ToInt32(Console.ReadLine());
        double[,] numbers = new double[linesVol, columnsVol];
        FillArrayRandomNumbers(numbers);
        PrintArray(numbers);

        void FillArrayRandomNumbers(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
                }
            }
        }

        void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("]");
                Console.WriteLine("");
            }
        }

        break;

        case 2:
        Console.WriteLine("введите номер строки");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите номер столбца");
        int m = Convert.ToInt32(Console.ReadLine());
        int [,] numbers1 = new int [10,10];
        FillArrayRandomNumbers1(numbers1);

        if (n > numbers1.GetLength(0) || m > numbers1.GetLength(1))
        {
            Console.WriteLine("такого элемента нет");
        }
        else
        {
            Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers1[n-1,m-1]}");
        }

        PrintArray1(numbers1);

        void FillArrayRandomNumbers1(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                {        
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array [i,j] = new Random().Next(-100, 100)/10;
                    }   
                }
        }

        void PrintArray1(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }   
                Console.Write("]");
                Console.WriteLine(""); 
            }
        }
        break;

        case 3:
        Console.WriteLine("введите количество строк");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите количество столбцов");
        int m1 = Convert.ToInt32(Console.ReadLine());

        int[,] numbers2 = new int[n1, m1];
        FillArrayRandomNumbers2(numbers2);


        for (int j = 0; j < numbers2.GetLength(1); j++)
        {
            double avarage = 0;
            for (int i = 0; i < numbers2.GetLength(0); i++)
            {
                avarage = (avarage + numbers2[i, j]);
            }
            avarage = avarage / n1;
            Console.Write(avarage + "; ");
        }
        Console.WriteLine();
        PrintArray2(numbers2);



        void FillArrayRandomNumbers2(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 10);
                }
            }
        }

        void PrintArray2(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("]");
                Console.WriteLine("");
            }
        }
        break;
    }
}