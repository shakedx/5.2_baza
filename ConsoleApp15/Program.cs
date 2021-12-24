using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int m = 7;
            int n = 5;
            int[,] A = new int[m, n];
            Console.WriteLine("Исходная матрица: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = r.Next(0, 10);
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < m; i++)
            {
                int summ = 0;
                for (int j = 0; j < n; j++)
                {
                    summ += A[i, j];
                }
                Console.WriteLine($"Сумма элементов {i + 1}-й строки равна {summ}");
            }
























            //int n = 7; //количество строк
            //int m = 5; //количество столбцов
            //int[,] matr = new int[n, m]; 
            //int[] array = new int[m]; 
            //Random r = new Random();
            //Console.WriteLine("Исходная матрица:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        matr[i, j] = r.Next(-10, 11); 
            //        Console.Write(matr[i, j].ToString() + "\t"); 

            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {

            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{


            //    int sum1 = 0, sum = 0;
            //    for (int j = 0; j < n; j++)
            //    {
            //        if 
            //        sum += matr[1, j];
            //        sum1 += matr[2, j];
            //    }
            //    if (sum1 > sum)
            //        //    array[j] = min; //добавляем элемент в массив
            //        //Console.Write(array[j].ToString() + "\t"); //выводим
            //        Console.WriteLine(" сумма элементов во второй строке больше");
            //    else Console.WriteLine(" сумма элементов во второй строке меньше");
        
        }
        
    }
}
