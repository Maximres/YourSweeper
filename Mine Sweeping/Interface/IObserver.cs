using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// ���������� ������� �������������� "�����������"
/// </summary>
namespace Mine_Sweeping
{
    public interface IObserver
    {
        void Update(EventArgs brgs);
    }
}
