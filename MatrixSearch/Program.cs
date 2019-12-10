using System;

namespace MatrixSearch {
    class Program {
        static void Main() {
            int[,] matrix = new int[10, 10];
            int[] aProizved = new int[10];  // Одномерный массив для нахождения произведения по столбцам матрицы
            int sumRow = 0;
            // Рандом
            Random r = new Random();
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;
            Console.WriteLine("Исходный двумерный массив:\n");
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    // Заполняет рандомными числами
                    matrix[i, j] = r.Next(1, 20);
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            // Сумма по строкам
            Console.WriteLine();
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    // Подсчет суммы каждой строки
                    sumRow += matrix[i, j];
                }
                Console.WriteLine();
                Console.Write("Сумма " + (i + 1) + " строки равна " + sumRow);
                sumRow = 0;
            }
            // Проходит по одноменому массиву
            for (int i = 0; i < aProizved.Length; i++) {
                aProizved[i] = 1;
            }
            // Проходит по матрице для нахождения произведения столбцов            
            for (int i = 0; i < 10; i++) {

                for (int j = 0; j < 10; j++) {

                    aProizved[i] *= matrix[j, i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Произведение элементов каждого столбца: \t ");
            for (int i = 0; i < aProizved.Length; i++) {
                Console.WriteLine(aProizved[i].ToString());
            }
            Console.ReadKey();
        }
    }
}
