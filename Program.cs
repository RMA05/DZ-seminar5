// семинар 5.
// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

        // int[] array = ArrayRandom();
        // int[] ArrayRandom()
        // {
        //     Random red = new Random();
        //     int[] array = new int[10];
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         array[i] = red.Next(100, 1000);
        //         System.Console.Write(array[i] + " | ");
        //         }
        //     return array;
        // }
        // void CountEven()
        // {
        //     int count = 0;
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         if (array[i] % 2 == 0)
        //             count++;
        //     }
        //     System.Console.WriteLine();
        //     System.Console.WriteLine("Колличество четных чисел в массиве :" + count);
        // }
        // CountEven();
    


// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int[] array = new int[6];
// void ArrayRandom(int[] array)
// {
//     Random red = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = red.Next(2, 10);
//         System.Console.Write(array[i] + " | ");
//     }
// }
// ArrayRandom(array);
// void SummOdd(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
    
//      if (array[i] % 2 != 0)
//             sum = sum + array[i];
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine(" Cумма на не четных позициях " + sum );
// }
// SummOdd(array);


// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] ArrayRandom()
// {
//     Random red = new Random();
//     double[] array = new double[red.Next(6)];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = red.NextDouble() + red.Next();
//         System.Console.Write(array[i] + " | ");
//     }
//     return array;
// }

//     void ArrayDifferense(double[] array)
//     {
//         double max = array[0];
//         double min = array[0];
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i] > max) max = array[i];
//             else if (array[i] < min) min = array[i];
//         }
//         System.Console.WriteLine();
//         Console.WriteLine($"Разница между max и min ");
//         System.Console.WriteLine(max - min);
//     }
//     ArrayDifferense(ArrayRandom());