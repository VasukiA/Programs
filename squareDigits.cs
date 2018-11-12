using System;

namespace MyApplication {

   class SquareDigits {
   
      static void Main(string[] args) {
         int number,output=0;
         Console.WriteLine("Enter the number");
         number=Convert.ToInt32(Console.ReadLine());
         while(number>0) {
             int reminder=number%10;
             output+=reminder*reminder;
             number/=10;
         }
         Console.WriteLine(output);
         Console.ReadKey();
      }
   }
}
