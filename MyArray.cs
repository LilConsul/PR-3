using System;
using System.Linq;

namespace PR_3 {
    public class MyArray {
        private readonly int[] arr;

        public MyArray(int a, int b) {
            if (a > b)
                throw new Exception("Задані межі не є правильними!");

            arr = new int[b - a + 1];
            for (var i = 0; i < arr.Length; i++)
                arr[i] = a + i;
        }
        
        //Повернути суму парних і кратних 7 чисел
        public int DoTask() => arr.Where(elem => elem % 2 == 0 && elem % 7 == 0).Sum();
    }
}