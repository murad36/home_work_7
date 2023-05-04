// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество столбцов: ");
int lines = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строчек: ");
int columns = int.Parse(Console.ReadLine());
Random rand = new Random();
int[,] array = new int[columns, lines];
rndArray(array);
PrintArray(array);
midArif(array, lines);

void midArif (int[,] array, int lines) {
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++) {
        double sum = 0;
    for (int j = 0; j < array.GetLength(0); j++) {
            sum = sum + array[j,i];     
    }
    sum = Math.Round(sum / lines,2);
    Console.Write( sum + " ");        
    }
}

void rndArray(int[,] array) {
    for (int j = 0; j < array.GetLength(0); j++) {
    for (int i = 0; i < array.GetLength(1); i++) {
    array[j,i] = rand.Next(0, 10);
    }
    }
}

void PrintArray(int[,] array) {
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            Console.Write(array[j, i] + " ");
        }
        
        Console.WriteLine(" ");
    }
}