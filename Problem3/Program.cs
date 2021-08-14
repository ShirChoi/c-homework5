using System;

namespace Problem3 {
    class Program {
        static void Main(string[] args) {
            int N = Read("Array size");
            int[] arr = new int[N];
            
            Random rnd = new Random(); // надеюсь этот класс можно использвать

            Console.Write("the array: ");
            for(int i = 0; i < N; i++) {
                arr[i] = rnd.Next(0, 50);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            int count = Read("count");
            int index = Read("index");

            int[] newArr = new int[count];

            for(int i = index; i < index + count; i++) 
                newArr[i - index] = i < N ? arr[i] : 1; 
            
            Console.Write("new array: ");

            foreach(int i in newArr) 
                Console.Write($"{i} ");
            
        }
        static int Read(string varName) {
            Console.Write($"{varName}: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
