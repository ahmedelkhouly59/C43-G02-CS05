using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASSIGNMENT4
{
    internal class Program
    {
        public static void swap(int x,int y)
        {
            int temp = x;
            x=y; 
            y=temp;
        }
        public static void swap_ref(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static int sumArray(int[] arr)
        {
            arr[0] = 100;
            int sum = 0;
            for (int i = 0;i<arr.Length;i++) 
                {
                    sum += arr[i];
                }
            return sum;
        }
        public static int sumArray_ref(ref int[] arr)
        {
            int sum = 0;
            arr[0] = 100;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static void SumSub (int a,int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
        }

        public static int sumindvidual (int n)
        {
            string num = Convert.ToString(n);
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += Convert.ToInt32(num.Substring(i, 1));
            }
            return sum;
        }
        public static bool IsPrime(int n)
        {
            bool prime ;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                prime = true;
            }
            else 
                prime = false;
            return prime;
        }
        public static void MinMaxArray(ref int[] arr, out int max,out int min)
        {
            min = arr[0];
            max= arr[1];
            for(int i = 0;i<arr.Length ; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
        }
        public static int factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return (num*factorial(num-1));
        }

        public static void ChangeChar(ref string input ,int position, char ch)
        {
            char[] chars = input.ToCharArray();
            if (position < chars.Length && position != null)
            {
                chars[position] = ch;
                input = new string(chars);
            }
        }



        static void Main(string[] args)
        {
            #region Q1 Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.:
            /* VALUE TYPE (PASS BY VALUE ) the parameters(varables passed to the function won't change after getting in and out of the function as the c# 
                will create for the parameters in function separate stack frame , inside it the parameters variable
               VALUE TYPE (PASS BY REFERENCE ) the parameters(varables passed to the function will change after getting in and out of the function if 
                is changed inside the function as it is is not created by the function stack frame*/
            //int x = 10;
            //int y = 20;
            //Console.WriteLine($"x before calling function is {x} ");
            //Console.WriteLine($"y before calling function is {y} ");
            //swap(x,y);
            //Console.WriteLine($"x after calling function is {x} ");
            //Console.WriteLine($"y after calling function is {y} ");

            //int a = 10;
            //int b = 20;
            //Console.WriteLine($"x before calling function is {a} ");
            //Console.WriteLine($"y before calling function is {b} ");
            //swap_ref(ref a, ref b);
            //Console.WriteLine($"a after calling function is {a} ");
            //Console.WriteLine($"b after calling function is {b} ");
            #endregion
            #region Q2 Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /* Both of them are gonna change in the values as you pass to them the address but the difference between passing by value and reference is
            the behaviour in (passing by value) you will make a variable in the stack frame of function that point to the addressbut in 
            (passing by reference ) it wll use the same variable the in the main function frame */

            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine($"arr[0] before calling function is {arr[0]}");
            //int result = sumArray(arr);
            //Console.WriteLine($"arr[0] after calling function is {arr[0]}");
            //Console.WriteLine($"Result is {result}");

            //int[] arr1 = { 1, 2, 3 };
            //Console.WriteLine($"arr[0] before calling function is {arr1[0]}");
            //int result1 = sumArray_ref(ref arr1);
            //Console.WriteLine($"arr[0] after calling function is {arr1[0]}");
            //Console.WriteLine($"Result is {result1}");
            #endregion
            #region Q3 Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //Console.Write("Enter the first number: ");
            //int x = int.Parse(Console.ReadLine() ?? "0");
            //Console.Write("Enter the second number: ");
            //int y = int.Parse(Console.ReadLine() ?? "0");
            //int sum, sub;
            //SumSub(x,y,out sum,out sub);
            //Console.WriteLine($"The Summation of the two numbers is {sum}");
            //Console.WriteLine($"The Subtraction of the two numbers is {sub}");

            #endregion
            #region Q4 Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.Write("Enter the number: ");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //int result = sumindvidual(num);
            //Console.WriteLine($"The sum of the indvidual digits of {num} is {result}");
            #endregion
            #region Q5 Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter the number to see if it is prime or no: ");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //bool res = IsPrime(num);
            //if (res)
            //{
            //    Console.WriteLine($"{num} is prime");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} isn't prime");
            //}
            #endregion
            #region Q6 Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters 
            //int[] arr = { 12, 2, 4, 20, 30, 19, 100, 39, 0 };
            //int max, min;
            //MinMaxArray(ref arr, out max, out min);
            //Console.WriteLine($"The maxmimum element in this array is {max}");
            //Console.WriteLine($"The minimum element in this array is {min}");
            #endregion
            #region Q7 Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter 
            //Console.Write("Enter a number to see its factorial: ");
            //int n = int.Parse(Console.ReadLine()??"0");
            //int result = factorial(n);
            //Console.Write($"The factorial of {n} is {result}");
            #endregion
            #region Q8 Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter 
            //Console.Write("Enter a string: ");
            //string i = Console.ReadLine();
            //Console.Write("Enter the new character to replace one of the characters in the string: ");
            //string ch = Console.ReadLine();
            //char c = ch[0];
            //Console.Write("Enter the position of the new character or the old charater in the string: ");
            //int p = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine($"\nThe string before changing the character: {i}");
            //ChangeChar(ref i, p, c);
            //Console.WriteLine($"\nThe string after changing the character: {i}");
            #endregion
        }

    }
}