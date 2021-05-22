using System;
using System.Diagnostics.Tracing;

namespace StatementsSequences
{
    class Program
    {
        static void Main(string[] args)
        {


            Palindrome();
        }

        static void Palindrome()
        {
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();
            string reverseWord = "";
            for (int i = word.Length; i > 0; i--) 
            {
                reverseWord += word[i-1].ToString();
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
        static void AskName()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            PrintName(name);
        }
        static void PrintName(string name)
        {
            Console.WriteLine("Name is " + name);
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
        static void TooHighTooLow()
        {
            Random _random = new Random();
            int num = _random.Next(10,100);
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

        static void PrintAlphabets()
        {
            int number = 65;
            char ch = (char)number;
            for (int i = 0; i < 26; i+=2)
            {
                ch = (char)number;
                Console.WriteLine(ch);
                number+=2;
            }
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

        static void NDiscount()
        {
            double NPercent = 50;
            double Price = 10;

            Console.WriteLine(Price - (Price * NPercent / 100));
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

        static void Celcius()
        {
            double valueToConvert = 55;
            Console.WriteLine((valueToConvert*1.8)+32);
        }

        static void Faranheit()
        {
            double valueToConvert = 55;
            Console.WriteLine((valueToConvert - 32)/1.8);
        }


        static void PoundToDolalr()
        {
            double exchangeRate = 1.4;
            double DolalrvalueToBeConverted = 550;
            Console.WriteLine(exchangeRate * DolalrvalueToBeConverted);
            return;
        }
    }
}
