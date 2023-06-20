using System;

namespace Demo {

   class MyArray {

      static void Main(string[] args) {

         int[] list = { 29, 15, 30, 98};

         int[] temp = list;

         Console.Write("Original Array: ");

         foreach (int i in list) {

            Console.Write(i + " ");

         }

         Console.WriteLine();

         //反转数组

         Array.Reverse(temp);

         Console.Write("Reversed Array: ");

         foreach (int i in temp) {

            Console.Write(i + " ");

         }

         Console.ReadKey();

      }

   }

}
