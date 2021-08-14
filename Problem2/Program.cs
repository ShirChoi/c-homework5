using System;

namespace Problem2 {
    class Program {
        static void Main(string[] args) {
            int N = Read("Размер массива");
            int[] arr = new int[N];
            int[] revArr = new int[N];

            for (int i = 0; i < N; i++) {
                arr[i] = Read($"элемент {i + 1}");
                revArr[N - i - 1] = arr[i];
            }
            
            System.Console.Write("Reverse array: ");
            foreach(int i in revArr) {
                System.Console.Write($"{i} ");
            }
        }

        static int Read(string varName) {
            Console.Write($"{varName}: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
