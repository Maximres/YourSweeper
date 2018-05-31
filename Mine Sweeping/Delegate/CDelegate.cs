using System;
using System.Collections.Generic;
using System.Text;

namespace Mine_Sweeping
{
    public delegate void Presenter(int x, int y,object obj);

    public delegate bool Condition(int x,int y);
}