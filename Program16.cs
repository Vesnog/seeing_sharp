using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         
         /* for loop execution */
         for (int a = 0, b = 1; a < 3 && b < 2; a++, b++) {
         //for (int a = 10, b = 15; a < 20; b < 17; a = a + 1; b++) {
            Console.WriteLine("value of a: {0}", a);
         }
         Console.ReadLine();
      }
   }
} 
