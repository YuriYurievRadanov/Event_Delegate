using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Delegate
{
    public class PrintHelper
    {
        public delegate void BeforePrint(string message);
        public event BeforePrint beforePrintEvent;


        public void PrintNumber(int num)
        {
            beforePrintEvent?.Invoke("PrintNumber");

            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
            beforePrintEvent?.Invoke("PrintDecimal");

            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            beforePrintEvent?.Invoke("PrintMoney");

            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
            beforePrintEvent?.Invoke("PrintTemerature");

            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }

        public void PrintHexadecimal(int dec)
        {
            beforePrintEvent?.Invoke("PrintHexadecimal");

            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}
