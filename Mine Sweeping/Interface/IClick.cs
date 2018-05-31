using System;
using System.Collections.Generic;
using System.Text;

namespace Mine_Sweeping
{
    public interface IClick
    {
        //������������� ���� ����
        bool RightClick(int x, int y, Presenter pr);

        //�������� �� �� ����
        bool LeftClick(int x, int y, Presenter pr);
        
        //������� ������
        bool BothClick(int x, int y, Presenter pr);
    }
}
