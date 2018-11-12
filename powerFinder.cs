using System;

namespace GitApplication {

   class PowerFinder {
   
      static void Main(string[] args) {
         int power;
         int number;
         Console.WriteLine("Enter the number to find power:");
         number=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter the power of number");
         power=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine(Math.Pow(number,power));
         Console.ReadKey();
      }
   }
}
