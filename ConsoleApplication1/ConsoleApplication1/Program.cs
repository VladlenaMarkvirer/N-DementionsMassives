using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int str = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int stlb = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();

            int[,] mas = new int[str, stlb];
            
            /*/ строка 1
            mas[0, 0] = 1;
            mas[0, 1] = 2;
            mas[0, 2] = 3;
            // строка 2
            mas[1, 0] = 4;
            mas[1, 1] = 5;
            mas[1, 2] = 6;*/

            // цикл для заполнения двумерного массива
            for (int row = 0; row < str; row++)
                for (int stb = 0; stb < stlb; stb++)
                    mas[row, stb] = rnd.Next(0, 11);

            // цикл для вывода двумерного массива
            Console.WriteLine("Двумерный массив:");
            for (int row = 0; row < str; row++)
            {
                for (int stb = 0; stb < stlb; stb++)
                    Console.Write(mas[row, stb] + " ");
                Console.WriteLine();
            }

            Console.Write("Введите количество массивов в рваном массиве: ");
            int c1 = Convert.ToInt32(Console.ReadLine());

            int[][] mas1 = new int[c1][];

            for (int row = 0; row < c1; row++)
            {
                Console.Write("Введите количество элементов в " + (row+1) + " элементе рваного массива: ");
                int c2 = Convert.ToInt32(Console.ReadLine());
                mas1[row] = new int[c2];
                for (int stb = 0; stb < c2; stb++)
                    mas1[row][stb] = rnd.Next(0, 11);
            }

            Console.WriteLine("Рваный массив:");
            for (int row = 0; row < mas1.Length; row++)
            {
                for (int stb = 0; stb < mas1[row].Length; stb++)
                    Console.Write(mas1[row][stb] + " ");
                Console.WriteLine();
            }

            Console.WriteLine("количество строк: " + mas.GetLength(0));
            Console.WriteLine("количество столбцов: " + mas.GetLength(1));

            Console.ReadLine();

            //ОТПРАВИТЬ КОД РЕБЯТАМ!!!
        }
    }
}
