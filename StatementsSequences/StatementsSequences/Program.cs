using System;
using System.Diagnostics.Tracing;
using System.Drawing;

namespace StatementsSequences
{
   
    class Program
    {
        static void Main(string[] args)
        {


            Palindrome( );
        }
        static void Palindrome()
        {
            while (true)
            {
                Console.WriteLine("Enter word");
                string word = Console.ReadLine();
                string reverseWord = "";
                for (int i = word.Length; i > 0; i--)
                {
                    reverseWord += word[i - 1].ToString();
                }
                if (reverseWord == word)
                {
                    Console.WriteLine("Palindrome");
                }
                else
                {
                    Console.WriteLine("Not Palindrome");
                }
            }
         
        }
        static void ShortProgram()
        {
            while (true)
            {
                Console.WriteLine("Press 1 for palindrome, 2 to play game, 3 to exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter word to check palidrome");
                    string word = Console.ReadLine();
                    CheckPalindrome(word);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Guess random generated number in the range of 10 to 100");
                    TooHighTooLow();
                }
                else { break; }
            }
        
        }
        static void CheckPalindrome(string word)
        {
            string reverseWord = "";
            for (int i = word.Length; i > 0; i--)
            {
                reverseWord += word[i - 1].ToString();
            }
            if (reverseWord == word)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
        static void TooHighTooLow()
        {

            Random _random = new Random();
            int num = _random.Next(10, 100);
            int guess;

            while (true)
            {
                Console.WriteLine("Enter Guessed Number");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < num) { Console.WriteLine("Too low"); }
                else if (guess > num) { Console.WriteLine("Too high"); }
                else { Console.WriteLine("Correct"); break; }
            }
        }
        static void PrintAlphabets()
        {
            int number = 66;
            char ch = (char)number;
            for (int i = 0; i < 26; i += 2)
            {
                ch = (char)number;
                Console.WriteLine(ch);
                number += 2;
            }
        }
        static void NDiscount()
        {
            Console.WriteLine("Enter discount in percentage");

            double NPercent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter price");
            double Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final price");
            Console.WriteLine(Price - (Price * NPercent / 100));
        }

        static void stackoverflow(out int a)
        {
            a = 2;
            Console.WriteLine(a);

        }

        static void Celcius()
        {
            Console.WriteLine("Enter Celcius");
            double valueToConvert = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((valueToConvert * 1.8) + 32);
        }

        static void PoundToDolalr()
        {
            Console.WriteLine("Enter Pound");
            
            double exchangeRate = 1.4;
            double DolalrvalueToBeConverted = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(exchangeRate * DolalrvalueToBeConverted);
            return;
        }
        static void Faranheit()
        {
            Console.WriteLine("Enter Farenheit");
            double valueToConvert = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((valueToConvert - 32) / 1.8);
        }


     
        static void AskName()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            PrintName(name);
        }
        static void PrintName(string name)
        {
            Console.WriteLine("Hello " + name);
        }




        static void Rectanlg()
        {
            Rectangle rect = new Rectangle(10, 20);
            Console.WriteLine("Area is " + rect.Area());
        }

        static void TimeOfDay()
        {
            Console.WriteLine("Enter hours, minutes, seconds");
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());
            int seconds = Convert.ToInt32(Console.ReadLine());
            TimeSpan mySpan = new TimeSpan(hours, minutes, seconds);
            Console.WriteLine("Seconds since mignight " + mySpan.TotalSeconds);
        }

        static void VAT()
        {
            Console.WriteLine("Enter price");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter VAT");
            double VAT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final price " + ((price*VAT/100) + price));
        }
        static void ProductDisplay()
        {
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product is " + num1 * num2);
        }
       
        
        static void SeperateArrays()
        {
            int[] myNum = { 10, 20, 30, 40, 41, 21, 31, 51 };
            int[] evenArray = new int[4];
            int[] oddArray = new int[4];
            int evenCounter = 0;
            int oddCounter = 0;

            foreach(int num in myNum)
            {
                if (num % 2 == 0)
                {
                    evenArray[evenCounter] = num;
                    evenCounter++;
                }
                else
                {
                    oddArray[oddCounter] = num;
                    oddCounter++;
                }
            }
            Console.WriteLine("Even array");
            foreach(int num in evenArray) { Console.WriteLine(num); }
            Console.WriteLine("Odd array");
            foreach (int num in oddArray) { Console.WriteLine(num); }

        }
        static void ArraysSum()
        {
            int[] myNum = { 10, 20, 30, 40 };
            int sum = 0; 
            foreach (int num in myNum)
            {
                sum = sum + num;
            }
            Console.WriteLine(sum);
        }
        static void ArraysReverse()
        {
            int[] myNum = { 10, 20, 30, 40 };
            for (int i = myNum.Length;i>0;i--)
            {
                Console.WriteLine(myNum[i-1]);
            }
        }
        static void Arrays()
        {
            int[] myNum = { 10, 20, 30, 40 };
            foreach(int num in myNum)
            {
                Console.WriteLine(num);
            }
        }

        static void NumberHalving()
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while((num = num / 2) >= 1)
            {
                counter++;
            }
            Console.WriteLine(counter);

        }

  
        static void PrintAlphabetsBackward()
        {
            int number = 90;
            char ch = (char)number;
            for (int i = 0; i < 26; i++)
            {
                ch = (char)number;
                Console.WriteLine(ch);
                number--;
            }
        }
        static void ConvertToChart()
        {
            int number = 65;
            char ch = (char)number;
            for(int i = 0; i < 26; i++)
            {
                ch = (char)number;
                Console.WriteLine(ch);
                number++;
            }
        }
        static void ConvertToMonth()
        {
            Console.Write("Enter Month number");
            int month = Convert.ToInt32(Console.ReadLine());
            DateTime dt = new DateTime(2021, month, 1);
            Console.WriteLine(dt.ToString("MMM"));
        }
        static void LargestThreeNumbers()
        {
            int a=55, b= 100, c = 20;
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
        }

        static void EligibleToVote()
        {
            Console.WriteLine("Enter Age");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age < 18)
            {
                Console.WriteLine("Can not vote");
            }
            else
            {
                Console.WriteLine("Can Vote");
            }
        }
        static void CheckDate()
        {
            Console.WriteLine("Inout year then month then day");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime dt = new DateTime(year,month,day);

            DateTime todayDate = DateTime.Now;
            if(DateTime.Compare(dt, todayDate) < 0)
            {
                Console.WriteLine("Before Todays Date");
                
            }
            else
            {
                Console.WriteLine("After todays Date");
            }
            


        }
        static void LeapYear()
        {
            int year = 2019;
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Yes it is Leap Year!");
            }
            else
            {
                Console.WriteLine("Not it is not a Leap Year!");
            }
        }

 

        static void InputAverage()
        {
            double average = 0;
            double input;
            for(int i =0; i< 4; i++)
            {
                input = Convert.ToDouble(Console.ReadLine());
                average = average + input;
            }
            Console.WriteLine("Average is => " + average / 4);

        }




        class Rectangle
        {
            int height;
            int width;
            public Rectangle(int _width, int _height)
            {
                width = _width;
                height = _height;
            }

            public int Area()
            {
                return width * height;
            }
        }
    }
}
