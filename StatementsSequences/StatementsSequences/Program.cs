using System;

namespace StatementsSequences
{
    class Program
    {
        static void Main(string[] args)
        {


            ConvertToMonth();
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
