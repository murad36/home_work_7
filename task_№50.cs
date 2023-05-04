// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество строк: ");
// int lines = int.Parse(Console.ReadLine());
// Random rand = new Random();
// int[,] array = new int[columns, lines];
// rndArray(array);
// PrintArray(array);
// orderNumber(array, columns, lines);


// void rndArray(int[,] array) {
//     for (int j = 0; j < array.GetLength(0); j++) {
//     for (int i = 0; i < array.GetLength(1); i++) {
//     array[j,i] = rand.Next(0, 10);
//     }
//     }
// }

// void orderNumber (int[,] array,int columns,int lines) {
//     Console.WriteLine("Введите число: ");
//     int number = int.Parse(Console.ReadLine());
//     int arrayLength = columns * lines - 1;
//     int k = 0; 
//     if (number > arrayLength){
//         Console.WriteLine($"Такого числа под индексом {number} нет");
//     }

//     else {
//     for (int i = 0; i < array.GetLength(0); i++) {
//     for (int j = 0; j < array.GetLength(1); j++) {
//         if(k == number) {
//             Console.WriteLine($"Число {array[i, j]} под индексом {number}");
//         }
//         k++;
//     }
//     }   
//     }  
// }

// void PrintArray(int[,] array) {
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


