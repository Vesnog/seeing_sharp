using System;

namespace PolymorphismApplication {
	// Members of the static class should also be static
	// No instance member in a static class
   static class Printdata {
      static void print(int i) {
         Console.WriteLine("Printing int: {0}", i );
      }
      static void print(double f) {
         Console.WriteLine("Printing float: {0}" , f);
      }
      static void print(string s) {
         Console.WriteLine("Printing string: {0}", s);
      }
      static void Main(string[] args) {
         // Printdata p = new Printdata();
         
         // Call print to print integer
         Printdata.print(5);
         
         // Call print to print float
         Printdata.print(500.263);
         
         // Call print to print string
         Printdata.print("Hello C++");
         Console.ReadKey();
      }
   }
}
