using System;

namespace MyApplication {

   class PrimeNumbers {
   
      static void Main(string[] args) {
         int start;
         int end;
         Console.WriteLine("Enter the intervals of two number");
         start=Convert.ToInt32(Console.ReadLine());
         end=Convert.ToInt32(Console.ReadLine());
         for(int i=start+1;i<end;i++) {
                         //     Console.WriteLine("b{0}",i);
             bool isPrime = true;
             for(int j=2;j<=i/2;j++) {
                // Console.WriteLine("a{0}",i);
                 if(i % j == 0) {
                     isPrime=false;
                 }
             }
             if(isPrime) {
                 Console.WriteLine(i);
             }
         }
         Console.ReadKey();
      }
   }
}
