using System;
using System.Collections.Generic;
using System.Text;

namespace Mine_Sweeping
{
    public class SweepingMap : IClick, IGetSetValue
    {
        #region Private Field
        /// <summary>
        /// Хранит мины
        /// </summary>

        private readonly ObjectList mines;

        /// <summary>
        /// Хранит найденные мины
        /// </summary>
        private readonly ObjectList flags;

        private readonly ObjectList hasAccessed;

        private int lines;

        private int columns;

        private int mineNums;

        private Random ran = new Random();

        #endregion

        #region Public Attributes
        public ObjectList Mines
        {
            get
            {
                return this.mines;
            }
        }

        public ObjectList Flags
        {
            get
            {
                return this.flags;
            }
        }

        public int Lines
        {
            get
            {
                return this.lines;
            }
            set
            {
                this.lines = value;
            }
        }

        public int Columns
        {
            get
            {
                return this.columns;
            }
            set
            {
                this.columns = value;
            }
        }

        public int MineNums
        {
            get
            {
                return this.mineNums;
            }
            set
            {
                this.mineNums = value;
            }
        }
        #endregion

        #region Constructor
        public SweepingMap()
        {
            this.mines = new ObjectList();

            this.flags = new ObjectList();

            hasAccessed = new ObjectList();
        }
        #endregion

        #region Private Methods

        private int CertainCondition(int x, int y, Condition condition)
        {
            int count = 0;

            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if ((i >= 0 && i < Lines) && (j >= 0 && j < Columns) && !(i == x && j == y))
                    {
                        if (condition(i, j))
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        private bool CheckSuccess()
        {
            int count = 0;

            foreach (GridObject f in Flags.ObjectTable.Keys)
            {
                foreach (GridObject m in Mines.ObjectTable.Keys)
                {
                    if (this.Flags.ObjectTable[f].Equals(this.Mines.ObjectTable[m]))
                    {
                        count++;
                    }
                }
            }
            if (count == Mines.ObjectTable.Count)
            {
                return true;
            }
            else
                return false;
        }

        #endregion

        #region Public Methods
        public void Initialization()
        {
            this.mines.Clear();

            this.flags.Clear();

            this.hasAccessed.Clear();

            for (int i = 0; i < this.MineNums; i++)
            {
                int x = ran.Next(this.Lines);

                int y = ran.Next(this.Columns);

                if (!this.mines.ContainsKey(x, y))
                    this.mines.Add(x, y);
                else
                    i -= 1;
            }
        }

        //установка флага 
        public bool RightClick(int x, int y, Presenter pr)
        {
            if (this.flags.ContainsKey(x, y))
            {
                this.flags.Remove(x, y);

                pr(x, y, true);
            }
            else
            {
                if (!this.hasAccessed.ContainsKey(x, y) && !this.flags.ContainsKey(x, y))
                {
                    this.flags.Add(x, y);

                    pr(x, y, false);
                }
            }

            if (this.Flags.Length == this.Mines.Length)
            {
                if (CheckSuccess())
                {
                    return true;
                }

            }

            return false;
        }

        //когда нарываешься на мину
        public bool LeftClick(int x, int y, Presenter pr)
        {
            if (!this.Flags.ContainsKey(x, y))
            {
                if (this.Mines.ContainsKey(x, y))
                {
                    pr(x, y, "Mine");

                    return false;
                }
                else
                {
                    GridTraversing(x, y, pr);
                    return true;
                }


            }
            return true;
        }

        /// <summary>
        /// Обход сетки
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="pr"></param>
        private void GridTraversing(int x, int y, Presenter pr)
        {
            Stack<GridObject> stack = new Stack<GridObject>();

            GridObject tmp = new GridObject(x, y);

            stack.Push(tmp);

            Condition condition = new Condition(Mines.ContainsKey);

            while (!(stack.Count == 0))
            {
                tmp = stack.Pop();

                int num = CertainCondition(tmp.XCoordinate, tmp.YCoordinate, condition);

                hasAccessed.Add(tmp.XCoordinate, tmp.YCoordinate);

                if (num == 0)
                {
                    pr(tmp.XCoordinate, tmp.YCoordinate, num);

                    for (int i = tmp.XCoordinate - 1; i <= tmp.XCoordinate + 1; i++)
                    {
                        for (int j = tmp.YCoordinate - 1; j <= tmp.YCoordinate + 1; j++)
                        {
                            if (i >= 0 && i < Lines && j >= 0 && j < Columns && !hasAccessed.ContainsKey(i, j) && !Flags.ContainsKey(i, j))
                            {
                                pr(i, j, num);

                                hasAccessed.Add(i, j);

                                stack.Push(new GridObject(i, j));
                            }
                        }
                    }
                }
                else
                {
                    pr(tmp.XCoordinate, tmp.YCoordinate, num);
                }

            }
        }

        //Двойнок клик
        public bool BothClick(int x, int y, Presenter pr)
        {

            Condition condition = new Condition(this.Mines.ContainsKey);

            int num = CertainCondition(x, y, condition);

            condition = new Condition(this.flags.ContainsKey);

            int count = CertainCondition(x, y, condition);

            if (count == 0)
                return true;
            if (num == count)
            {
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < Lines && j >= 0 && j < Columns && !(i == x && j == y))
                        {
                            if (!(this.flags.ContainsKey(i, j)))
                            {
                                if (!LeftClick(i, j, pr))
                                    return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

        public void DisplayAllMines(int x, int y, Presenter pr)
        {
            int i, j;

            foreach (GridObject cur in mines.ObjectTable.Keys)
            {
                i = mines.ObjectTable[cur].XCoordinate;

                j = mines.ObjectTable[cur].YCoordinate;

                if (i != x && j != y)
                    pr(i, j, mines.ObjectTable[cur]);
            }
        }

        #endregion
    }
}
