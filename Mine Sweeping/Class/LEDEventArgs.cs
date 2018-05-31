using System;
using System.Collections.Generic;
using System.Text;

namespace Mine_Sweeping
{
    public class LEDEventArgs : EventArgs
    {
        private int number;

        public LEDEventArgs(int num)
        {
            number = num;
        }

        public int Number
        {
            get
            {
                return this.number;
            }
        }

    }
}