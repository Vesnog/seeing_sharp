using System;

namespace CalculatorApplication {
   class NumberManipulator {
      public void getValue(out int x ) {
         int temp = 5;
         x = temp;
      }
      public void getValues_KB(out int x, out int y ) {
          Console.WriteLine("Enter the first value: ");
          x = Convert.ToInt32(Console.ReadLine());
          
          Console.WriteLine("Enter the second value: ");
          y = Convert.ToInt32(Console.ReadLine());
      }
      static void Main(string[] args) {
         NumberManipulator n = new NumberManipulator();
         
         /* local variable definition */
         int a = 100;
         
         Console.WriteLine("Before method call, value of a : {0}", a);
         
         /* calling a function to get the value */
         n.getValue(out a);

         Console.WriteLine("After method call, value of a : {0}", a);
         Console.ReadLine();
         
        int c , d;
         
         /* calling a function to get the values */
         n.getValues_KB(out c, out d);
         Console.WriteLine("This is the second method");
         Console.WriteLine("After method call, value of a : {0}", c);
         Console.WriteLine("After method call, value of b : {0}", d);
         Console.ReadLine();
      }
   }
}
