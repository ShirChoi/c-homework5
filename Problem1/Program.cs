using System;

namespace Problem1 {
    class Program {
        static void Main(string[] args) {
            int N = Read("Введите размер массива");

            int[] arr = new int[N];

            Random rnd = new Random(); // надеюсь этот класс можно использвать
            
            Console.Write("массив: ");

            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;

            for(int i = 0; i < N; i++) {
                arr[i] = rnd.Next(0, 50);
                min = Math.Min(arr[i], min);
                max = Math.Max(arr[i], max);
                sum += arr[i];
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine($"минимальный элемент: {min}");
            Console.WriteLine($"максимальный элемент: {max}");
            Console.WriteLine($"сумма элементов: {sum}");
            Console.WriteLine($"Среднее арифметическое элементов: {((double)sum) / N}");
            Console.Write($"Нечётные элементы: ");

            foreach(int i in arr) 
                if(i % 2 == 1) 
                    Console.Write($"{i} ");
                
        }
        static int Read(string varName) {
            Console.Write($"{varName}: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
