using System;
using System.Collections.Generic;
using System.Text;

namespace Mine_Sweeping
{
    public interface ICoordinate
    {
        int XCoordinate { get;}

        int YCoordinate { get;}

        void SetCoordinate(int x, int y);
    }
}
