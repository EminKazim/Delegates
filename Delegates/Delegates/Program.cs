using System;
using System.Collections.Generic;

namespace Delegates
{
    //public delegate bool Check(int num);
    //public delegate void FixText(string str);
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(CheckDivisibleBy6, 2, 6, 12, 13, 18));
            //FixText words = new FixText(StringToUpper);
            //words.Invoke("Cavid");
            //FixText words = StringToUpper;
            //words += StringToLower;
            ////words += delegate (string s)
            //// {
            ////     s.ToUpper();
            //// };
            //words += s => Console.WriteLine(s.ToUpper());
            //words("Elnur");
            List<int> nums = new List<int> { 2, 10, 12, 13, 14, 15, 18 };
            var list = nums.FindAll(m => m % 6 == 0);
            //Action<string> word = StringToUpper;
            //word("Elnur");
            Func<string, int> print = StrLength;
            Console.WriteLine(print("Elnur"));




            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        

        public static void StringToUpper(string str )
        {
            Console.WriteLine(str.ToUpper());
        }
        public static void StringToLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }

        public static bool CheckDivisibleBy6(int num)
        {
            return  num % 6 == 0;

        }
        public static bool CheckAviableNums(int num)
        {
            return num > 6;
        }
        //public static int Sum(Check  methods, params int[] nums)
        public static int Sum(Predicate<int> methods, params int[] nums)
        {
            var  sum = 0;
            foreach (var item in nums)
            {
                if(methods(item))
                {
                     sum += item;
                }
            }
            return sum;

        }
        public static int StrLength(string str)
        {
            return str.Length;
        }

    }
}

