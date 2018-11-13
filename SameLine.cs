using System;

namespace MyApplication {
   
   class SameLine {

      static void Main(string[] args) {
         Console.WriteLine("Enter 3 points:");
         int[] array=new int[6];
      
            for(int i=0;i<6;i++) {
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
             if(array[0] == array[2]&& array[2] == array[4]) {
             Console.WriteLine("YES");
             } else if(array[1] == array[3] && array[3] == array[5]) {
                              Console.WriteLine("YES");
             } else {
            Console.WriteLine("NO");
         }
      }
   }
}
