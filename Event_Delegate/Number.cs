using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Delegate
{
    class Number
    {
        private PrintHelper _printHelper;

        public Number(int val)
        {
            _value = val;

            _printHelper = new PrintHelper();
            //subscribe to beforePrintEvent event
            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
        }
        //beforePrintevent handler
        void printHelper_beforePrintEvent(string message)
        {
            Console.WriteLine("BeforePrintEvent fires from {0}", message);
        }

        private int _value;

        public int Value
        {
            get => _value;
            set => _value = value;
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }
    }
}
