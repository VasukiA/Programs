using System;

namespace MyApplication {
   
   class GreatestDivider {

      static void Main(string[] args) {
         Console.WriteLine("Enter two numbers:");
         int firstNumber=Convert.ToInt32(Console.ReadLine());
         int secondNumber=Convert.ToInt32(Console.ReadLine());
         int output=firstNumber;
          if(firstNumber>secondNumber) {
              if(firstNumber%secondNumber==0) {
                  output=secondNumber;
              }
          } else {
                if(secondNumber%firstNumber==0) {
                  output=firstNumber;
              }
          }
            Console.WriteLine("THe greatest divider: {0}",output);
      }
   }
}
