using System;

namespace ArrayApplication {
   class Function {
      public double getAverage(int[] arr, int size) {
         int i;
         double avg;
         int sum = 0;
         
         for (i = 0; i < size; ++i) {
            sum += arr[i];
         }
         avg = (double)sum / size;
         return avg;
      }
  }
   class MyArray {
      static void Main(string[] args) {
         
         /* a jagged array of 5 array of integers*/
         int[][] a = new int[][]{new int[]{0,0},new int[]{1,2},
            new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };
         int i, j;
         
         /* output each array element's value */
         for (i = 0; i < 5; i++) {
            for (j = 0; j < 2; j++) {
               Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
            }
         }
         Console.ReadKey();
         Function app = new Function();
         
         /* an int array with 5 elements */
         int [] balance = new int[]{1000, 2, 3, 17, 50};
         double avg;

         /* pass pointer to the array as an argument */
         avg = app.getAverage(balance, 5 ) ;

         /* output the returned value */
         Console.WriteLine( "Average value is: {0} ", avg );
         Console.ReadKey();
      }
   }
}
