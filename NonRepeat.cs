using System;

namespace MyApplication {

   class NonRepeat {
   
      static void Main(string[] args) {
         int arraySize;
         Console.WriteLine("Enter the array size:");
         arraySize=Convert.ToInt32(Console.ReadLine());
         int [] numberArray=new int[arraySize];
                  Console.WriteLine("Enter the array values:");
         for(int index=0;index<arraySize;index++) {
             numberArray[index] = Convert.ToInt32(Console.ReadLine());
         }
         for(int index=0;index<arraySize;index++) {
             bool isRepeated=true;
             for (int j=0;j<arraySize;j++) {
                 if(index!=j) {
                   
                     if(numberArray[index] == numberArray[j]) {
                         isRepeated=false; 
                     }
                 }
             }
             if(isRepeated) {
                          Console.WriteLine(numberArray[index]);
             }
         }
         Console.ReadKey();
      }
   }
}
