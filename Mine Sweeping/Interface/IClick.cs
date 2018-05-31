using System;
using System.Collections.Generic;
using System.Text;

namespace Mine_Sweeping
{
    public interface IClick
    {
        //Устанавливает флаг мины
        bool RightClick(int x, int y, Presenter pr);

        //Нарвался ли на мину
        bool LeftClick(int x, int y, Presenter pr);
        
        //Двойной щелчок
        bool BothClick(int x, int y, Presenter pr);
    }
}
