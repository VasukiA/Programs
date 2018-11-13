using System;

namespace MyApplication {
   
   class Anagram {

      static void Main(string[] args) {
         string input = Console.ReadLine();
         int output=0;
         int size=Convert.ToInt32(Console.ReadLine());
         string [] compareInputs=new string[size];
         for(int i=0;i<size;i++) {
             compareInputs[i]=Console.ReadLine();
         }
         char[] inputArray=input.ToCharArray();
         Array.Sort(inputArray);
         int inputLength=input.Length;
         for(int i = 0;i < size; i++) {
             if(inputLength == compareInputs[i].Length) {
             char[] checkedArray=compareInputs[i].ToCharArray();
             Array.Sort(checkedArray);
             int count=0;
             for(int j=0;j<inputLength;j++) {
                  if(inputArray[j] == checkedArray[j]) {
                      count++;
                  }
                }
                if(inputLength==count) {
                    output++;
                }
             }
         }
         Console.WriteLine(output);
      }
   }
}
