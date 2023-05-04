// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество столбцов: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество строк: ");
// int n = int.Parse(Console.ReadLine());
// double[,] array = new double[m, n];
// Random rand = new Random();
// rndArray(array);
// PrintArray(array);

// void rndArray(double[,] array) {
//     int max_2 = 100;
//     int min_2 = -100;
//     for (int j = 0; j < array.GetLength(0); j++) {
//     for (int i = 0; i < array.GetLength(1); i++) {
//     array[j,i] = Math.Round(rand.NextDouble() * (max_2 - min_2) + min_2,2);
//     }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine(",");
//     }
// }