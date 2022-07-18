using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home7
{
    class Program
    {
        static void Main(string[] args)
        {/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
            вещественными числами.
            m = 3, n = 4.
            0,5 7 -2 -0,2
            1 -3,3 8 -9,9
            8 7,8 -7,1 9*/
            double [,] CreateArray(double[,] arr,int m,int n)
            {
                Random rnd = new Random();
                for (int i = 0; i < m; i++)
                {
                    for(int j=0;j<n;j++)
                    arr[i,j] = (double)rnd.Next(-100,100)/10.0;
                }
                    return arr;
            }
            void PrintArray(double[,] arr,int m,int n)
            {
                for(int i=0;i<m;i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write(arr[i, j] + "\t");
                    Console.WriteLine();
                }
            }
            /*
            Задача 50. Напишите программу, которая на вход принимает позиции элемента 
            в двумерном массиве, и возвращает значение этого элемента или же указание,
            что такого элемента нет.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            17 -> такого числа в массиве нет
            Задача 52. Задайте двумерный массив из целых чисел. 
            Найдите среднее арифметическое элементов в каждом столбце.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
            double[,] array;
            int M, N;
            bool num;
            Console.WriteLine("Задайте двумерный массив размером M x N, заполненный случайными" +
                " вещественными числами");
            res: Console.Write("введите размер массива. количество строк -");
            num = int.TryParse(Console.ReadLine(),out M);
        res2:
            if (num)
            {
                Console.Write("введите количество столбов - ");
            }
            else goto res;
            num = int.TryParse(Console.ReadLine(), out N);
            
            if (!num)
            {
                num = true;
                goto res2;
            }
            array = new double[M, N];
            CreateArray(array,M,N);
            PrintArray(array, M, N);
            Console.ReadKey();
        }
    }
}
