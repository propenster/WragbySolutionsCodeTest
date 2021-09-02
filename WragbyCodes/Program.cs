using System;
using System.Linq;
using System.Collections.Generic;


namespace WragbyCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Question 1
            string word;
            Console.WriteLine("Please enter a string");
            word = Console.ReadLine();
            Console.WriteLine($"String: {word} transformed removing duplicate characters => {RemoveDuplicateChars(word)}\n");

            //Question 2:
            string reverseWord;
            Console.WriteLine("Please enter a string you want to reverse");
            reverseWord = Console.ReadLine();
            Console.WriteLine($"String: {reverseWord} when reversed => {ReverseString(reverseWord)}\n");

            //Question 3:
            // write a method to returns the second largest
            int[] numArrayToSort = new int[] {1, 2, 3, 4, 5, 6, 7, 8};
            Console.WriteLine($"The Second Largets Number in this array is => {FindSecondLargestNumInArray(numArrayToSort)}\n");


            //Question 4:
            int[] numArray = new int[] {1, 2, 3, 4, 5, 6, 7, 8};
            Console.WriteLine($"Sum of Even Numbers in this Array is => {SumEvenNumbersInArray(numArray)}\n");

            //Question 5:
            //Method overloading
            int length = 5;
            int breadth = 10;
            Console.WriteLine($"Area of Rectangle => {CalculateArea(length, breadth)}\n");
            Console.WriteLine($"Area of Square => {CalculateArea(length)}\n");


            //Question 6:
            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("Weindenberger!");
            Console.WriteLine($"Sort of the List by string length and Name => {SortList(stringList)}");


        }

        private static int FindSecondLargestNumInArray(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);

            return array[1];
        }

        private static int CalculateArea(int length, int breadth)
        {
            //this is for a rectangle 
            return length * breadth;
        }

        private static int CalculateArea(int length)
        {
            //for a square the same CalculateArea method can have onlhy one L. and area is L*L
            return length * length;
        }

        private static List<string> SortList(List<string> listOfString)
        {
            return listOfString.OrderBy(x => x.Length).OrderBy(x => x.Name);
        }

        private static int SumEvenNumbersInArray(int[] array)
        {
            int sum = 0;
            for(int i = 0; i<array.Length; i++){
                if(IsEvenNumber(array[i])){
                    sum += array[i];
                }
            }

            return sum;
        }

        private static bool IsEvenNumber(int num)
        {
            bool isEven = true;

            if(num % 2 != 0) isEven = false;

            return isEven;
        }

        private static string ReverseString(string word)
        {
            string result = "";
            for(int i = word.Length-1; i>=0; i--){
                result +=word[i];
            }

            return result;
        }

        private static string RemoveDuplicateChars(string word)
        {
            HashSet<char> stringSet = new HashSet<char>();
            StringBuilder sb = new StringBuilder();
            string result;
            word = word.Replace(" ", "");
            foreach(char c in word){
                stringSet.Add(c);
            }
            foreach(char c in stringSet){
                sb.Append(c);
            }

            result = sb.ToString();

        }
    }
}
