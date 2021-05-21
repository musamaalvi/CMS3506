using System;

namespace StatementsSequences
{
    class Program
    {
        static void Main(string[] args)
        {


            NDiscount();
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
