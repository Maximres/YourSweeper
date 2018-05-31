using System;
using System.Collections.Generic;
using System.Text;

namespace Mine_Sweeping_Window
{
    public class SettingItems
    {
        private int rowNumber;

        private int columnNumber;

        private int minesNumber;

        public int RowNumber
        {
            get
            {
                return this.rowNumber;
            }
            set
            {
                this.rowNumber = value;
            }
        }

        public int ColumnNumber
        {
            get
            {
                return this.columnNumber;
            }
            set
            {
                this.columnNumber = value;
            }
        }

        public int MineNumber
        {
            get
            {
                return this.minesNumber;
            }
            set
            {
                this.minesNumber = value;
            }
        }

        public SettingItems(int r,int c,int m)
        {
            this.rowNumber = r;

            this.columnNumber = c;

            this.minesNumber = m;
        }

        public SettingItems()
        {
        }
    }
}
